using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using WMPLib;

namespace RandomRest
{
    public partial class RandomRest : Form
    {
        WindowsMediaPlayer startSoundPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer endSoundPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer timerSoundPlayer = new WindowsMediaPlayer();
        bool isRunning = false;
        bool _systemShutDown = false;
        Thread alarmer;
        int timerTimeLeft;

        public RandomRest()
        {
            InitializeComponent();
            //if (!File.Exists("Setting.txt"))
            //    CreateSettingFile();
            //string[] settings = File.ReadAllLines("Setting.txt");

            string startSoundPath = @"Sound Effects\start.mp3";
            string endSoundPath = @"Sound Effects\end.mp3";
            string timerSoundPath = @"Sound Effects\alarm.mp3";
            //다른 환경에서도 작동하게 하기 위해 상대결로로 하드코딩 후 절대경로로 변환
            startSoundPath = Path.GetFullPath(startSoundPath);      //상대경로에서 절대경로로 변환
            endSoundPath = Path.GetFullPath(endSoundPath);          //상대경로에서 절대경로로 변환
            timerSoundPath = Path.GetFullPath(timerSoundPath);

            //파일을 찾을 수 있는지 확인
            if (!File.Exists(startSoundPath) || !File.Exists(endSoundPath) || !File.Exists(timerSoundPath)) 
                MessageBox.Show("사운드 파일을 찾을 수 없습니다");

            // 사운드
            startSoundPlayer.URL = startSoundPath;
            endSoundPlayer.URL = endSoundPath;
            timerSoundPlayer.URL = timerSoundPath;

            //설정에 저장된 기본값 대입
            TimeIntervalTextBox.Text = Properties.Settings.Default.intervalTime.ToString();
            TimeRangeTextBox.Text = Properties.Settings.Default.rangeTime.ToString();
            RestTimeTextBox.Text = Properties.Settings.Default.restTime.ToString();
            IsMinuteCheckBox.Checked = Properties.Settings.Default.IsMinute;
        }

        //private void CreateSettingFile()
        //{
        //    //새 설정 파일을 생성
        //    File.Create("Setting.txt");
        //    string[] setting = { @"Start Sound Effect: Sound Effects\MP_맑은 벨 알림음 - 7.mp3" ,
        //                          @"End Sound Effect: Sound Effects\MP_Tiny Button Push.mp3",
        //                          @"Rest Time: 10"};
        //    File.WriteAllLines("Setting.txt", setting);
        //}

        //private void ReadSettings(string[] settings)
        //{
        //    // 설정을 읽어 딕셔너리 값으로 반환

        //}

        //private string FindSetting(string[] settings, string setting_name)
        //{
        //    // 설정집에서 매개변수로 받은 설정의 이름을 찾아 ": "뒤의 값을 반환합니다.
        //    for (int i = 0; i < settings.Length; i++)
        //    {
        //        if (settings[i].IndexOf(setting_name) != -1)
        //            return settings[i].Substring(settings[i].IndexOf(": ") + 3);
        //    }
        //    return "";      //설정 값을 찾지 못했다면 빈 문자열을 반환합니다.
        //}

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartAlarm();
        }

        private void StartAlarm()
        {
            startSoundPlayer.controls.play();
            if (isRunning)      //이미 실행중이라면 무시함
                return;
            int time_interval;  //알람이 울릴 간격
            int time_range;     //알람이 울리는 간격이 변화할 수 있는 최대 범위

            //제대로 입력했는지 확인
            #region
            if (TimeIntervalTextBox.Text == "")
            {
                MessageBox.Show("알림이 울릴 간격을 입력하십시오");
                StopAlarm();
                return;
            }
            else if (!int.TryParse(TimeIntervalTextBox.Text, out time_interval))
            {
                MessageBox.Show("알림이 울릴 간격에 숫자를 입력하시오");
                StopAlarm();
                return;
            }
            else if (TimeRangeTextBox.Text == "")
            {
                MessageBox.Show("알림이 울리는 시간이 변화가능한 범위를 입력하십시오");
                StopAlarm();
                return;
            }
            else if (!int.TryParse(TimeRangeTextBox.Text, out time_range))
            {
                MessageBox.Show("알림이 울리는 시간이 변화가능한 범위에는 숫자를 입력하시오");
                StopAlarm();
                return;
            }
            #endregion
            time_interval = int.Parse(TimeIntervalTextBox.Text);
            time_range = int.Parse(TimeRangeTextBox.Text);

            // 알람 스레드 생성 및 실행
            alarmer = new Thread(() => Alarm(time_interval, time_range));
            alarmer.Start();
        }

        ///<summary>알람이 울릴 간격과 그 간격에서 변화할 범위로 다음 알람이 울릴 
        ///시간을 정하고 그 시간동안 기다린 후에 시작 알람이 울린다.
        ///이후 대기 시간동안 기다렸다가 마침 알람이 울리기를 반복</summary>
        ///<param name="time_interval">알람이 울릴 시간 간격</param>
        ///<param name="time_range">알람이 울릴 간격이 변화할 범위</param>
        private void Alarm(int time_interval, int time_range)
        {
            int time;
            Random rand = new Random();
            isRunning = true;   //작동중으로 상태변화
            var restTime = int.Parse(RestTimeTextBox.Text);
            int singleTime;
            if (IsMinuteCheckBox.Checked)
                singleTime = 60 * 1000;
            else
                singleTime = 1000;

            while (true)
            {
                time = time_interval + rand.Next(-time_range, time_range); //다음 알람이 울리기까지 시간
                for (int i = time; i > 0; i--)
                {
                    StatePanel.BackColor = System.Drawing.Color.Yellow;
                    string timeLeftText = "남은 시간\n" + i.ToString() + (IsMinuteCheckBox.Checked ? "분" : "초");
                    setText_Control(StateLabel, timeLeftText);
                    notifyIcon.Text = StateLabel.Text;
                    Thread.Sleep(singleTime);                //시간 기다림
                }  
                startSoundPlayer.controls.play();       //시작 알람 울림

                for (int i = restTime; i > 0; i--)
                {
                    StatePanel.BackColor = System.Drawing.Color.Green;
                    setText_Control(StateLabel, "휴식 시간\n" + i);
                    Thread.Sleep(singleTime);            //휴식 시간
                }
                endSoundPlayer.controls.play();         //마침 알람 울림
            }
        }

        delegate void CtrInvoke(Control control, string text);
        private void setText_Control(Control control, string text)
        {
            if(control.InvokeRequired)
            {
                CtrInvoke c = new CtrInvoke(setText_Control);
                control.Invoke(c, control, text);   
            }
            else
            {
                control.Text = text;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
           StopAlarm();
        }


        private void StopAlarm()
        {
            endSoundPlayer.controls.play();
            if (!isRunning)     //시작하지 않았다면 무시
                return;
            isRunning = false;
            if(alarmer != null && alarmer.IsAlive)
            {
                alarmer.Abort();    //알람 스레드 종료
            }

            StatePanel.BackColor = System.Drawing.Color.Red;
            StateLabel.Text = "꺼짐";
        }

        /// <summary>종료시 잔여 스레드 종료 및 설정값 저장</summary>
        private void RandomRest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_systemShutDown)
            {
                e.Cancel = false;
                StopAlarm();
            }
            else
            {
                e.Cancel = true;
                this.Visible = false;
            }

            // 설정값 저장
            Properties.Settings.Default.intervalTime = int.Parse(TimeIntervalTextBox.Text);
            Properties.Settings.Default.rangeTime = int.Parse(TimeRangeTextBox.Text);
            Properties.Settings.Default.restTime = int.Parse(RestTimeTextBox.Text);
            Properties.Settings.Default.IsMinute = IsMinuteCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ActivateTrayBarMenu_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            _systemShutDown = true;
            this.Close();
            Application.Exit();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAlarm();
        }
        private void Timer_minute(object sender, EventArgs e)
        {
            timerTimeLeft -= 1;
            if(timerTimeLeft > 0)
            {
                string timeLeftText = "타이머: " + timerTimeLeft + "분";
                setText_Control(StateLabel, timeLeftText);
            }
            else
            {
                timer.Stop();
                timerSoundPlayer.controls.play();
                MessageBox.Show("Timer is over!");
            }
        }

        private void setTimer(int minute)
        {
            timerTimeLeft = minute;
            string timeLeftText = "타이머: " + timerTimeLeft + "분";
            setText_Control(StateLabel, timeLeftText);
            timer.Start();
        }

        private void minute1TSMI_Click(object sender, EventArgs e)
        {
            setTimer(1);
        }

        private void minute5TSMI_Click(object sender, EventArgs e)
        {
            setTimer(5);
        }

        private void minute10TSMI_Click(object sender, EventArgs e)
        {
            setTimer(10);
        }

        private void minute30TSMI_Click(object sender, EventArgs e)
        {
            setTimer(30);
        }

        private void minute60TSMI_Click(object sender, EventArgs e)
        {
            setTimer(60);
        }

        private void minute120TSMI_Click(object sender, EventArgs e)
        {
            setTimer(120);
        }
    }
}
