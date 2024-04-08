namespace RandomRest
{
    partial class RandomRest
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomRest));
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TimeRangeLabel = new System.Windows.Forms.Label();
            this.TimeIntervalTextBox = new System.Windows.Forms.TextBox();
            this.TimeRangeTextBox = new System.Windows.Forms.TextBox();
            this.StatePanel = new System.Windows.Forms.Panel();
            this.StateLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivateTrayBarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestTimeLabel = new System.Windows.Forms.Label();
            this.RestTimeTextBox = new System.Windows.Forms.TextBox();
            this.IsMinuteCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeIntervalLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.타이머ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.분ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StatePanel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 234);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 75);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(220, 234);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(150, 75);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TimeRangeLabel
            // 
            this.TimeRangeLabel.AutoSize = true;
            this.TimeRangeLabel.Location = new System.Drawing.Point(9, 115);
            this.TimeRangeLabel.Name = "TimeRangeLabel";
            this.TimeRangeLabel.Size = new System.Drawing.Size(227, 15);
            this.TimeRangeLabel.TabIndex = 1;
            this.TimeRangeLabel.Text = "간격이 변할 수 있는 범위를 입력";
            // 
            // TimeIntervalTextBox
            // 
            this.TimeIntervalTextBox.Location = new System.Drawing.Point(12, 62);
            this.TimeIntervalTextBox.Name = "TimeIntervalTextBox";
            this.TimeIntervalTextBox.Size = new System.Drawing.Size(224, 25);
            this.TimeIntervalTextBox.TabIndex = 3;
            // 
            // TimeRangeTextBox
            // 
            this.TimeRangeTextBox.Location = new System.Drawing.Point(12, 133);
            this.TimeRangeTextBox.Name = "TimeRangeTextBox";
            this.TimeRangeTextBox.Size = new System.Drawing.Size(224, 25);
            this.TimeRangeTextBox.TabIndex = 3;
            // 
            // StatePanel
            // 
            this.StatePanel.BackColor = System.Drawing.Color.Red;
            this.StatePanel.Controls.Add(this.StateLabel);
            this.StatePanel.Location = new System.Drawing.Point(260, 60);
            this.StatePanel.Name = "StatePanel";
            this.StatePanel.Size = new System.Drawing.Size(100, 100);
            this.StatePanel.TabIndex = 4;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateLabel.Location = new System.Drawing.Point(3, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(94, 96);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "꺼짐";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "text?";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.ActivateTrayBarMenu,
            this.ExitMenu});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(116, 100);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // ActivateTrayBarMenu
            // 
            this.ActivateTrayBarMenu.Name = "ActivateTrayBarMenu";
            this.ActivateTrayBarMenu.Size = new System.Drawing.Size(115, 24);
            this.ActivateTrayBarMenu.Tag = "DIC";
            this.ActivateTrayBarMenu.Text = "Show";
            this.ActivateTrayBarMenu.Click += new System.EventHandler(this.ActivateTrayBarMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(115, 24);
            this.ExitMenu.Tag = "EXIT";
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // RestTimeLabel
            // 
            this.RestTimeLabel.AutoSize = true;
            this.RestTimeLabel.Location = new System.Drawing.Point(9, 185);
            this.RestTimeLabel.Name = "RestTimeLabel";
            this.RestTimeLabel.Size = new System.Drawing.Size(122, 15);
            this.RestTimeLabel.TabIndex = 1;
            this.RestTimeLabel.Text = "휴식 시간을 입력";
            // 
            // RestTimeTextBox
            // 
            this.RestTimeTextBox.Location = new System.Drawing.Point(12, 203);
            this.RestTimeTextBox.Name = "RestTimeTextBox";
            this.RestTimeTextBox.Size = new System.Drawing.Size(224, 25);
            this.RestTimeTextBox.TabIndex = 3;
            // 
            // IsMinuteCheckBox
            // 
            this.IsMinuteCheckBox.AutoSize = true;
            this.IsMinuteCheckBox.Location = new System.Drawing.Point(242, 205);
            this.IsMinuteCheckBox.Name = "IsMinuteCheckBox";
            this.IsMinuteCheckBox.Size = new System.Drawing.Size(139, 19);
            this.IsMinuteCheckBox.TabIndex = 5;
            this.IsMinuteCheckBox.Text = "기준을 분침으로";
            this.IsMinuteCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimeIntervalLabel
            // 
            this.TimeIntervalLabel.AutoSize = true;
            this.TimeIntervalLabel.Location = new System.Drawing.Point(9, 44);
            this.TimeIntervalLabel.Name = "TimeIntervalLabel";
            this.TimeIntervalLabel.Size = new System.Drawing.Size(237, 15);
            this.TimeIntervalLabel.TabIndex = 1;
            this.TimeIntervalLabel.Text = "알람이 울릴 평균적인 간격을 입력";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.타이머ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 타이머ToolStripMenuItem
            // 
            this.타이머ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.분ToolStripMenuItem,
            this.분ToolStripMenuItem1,
            this.분ToolStripMenuItem2,
            this.분ToolStripMenuItem3,
            this.분ToolStripMenuItem4,
            this.분ToolStripMenuItem5});
            this.타이머ToolStripMenuItem.Name = "타이머ToolStripMenuItem";
            this.타이머ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.타이머ToolStripMenuItem.Text = "타이머";
            // 
            // 분ToolStripMenuItem
            // 
            this.분ToolStripMenuItem.Name = "분ToolStripMenuItem";
            this.분ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.분ToolStripMenuItem.Text = "1분";
            this.분ToolStripMenuItem.Click += new System.EventHandler(this.minute1TSMI_Click);
            // 
            // 분ToolStripMenuItem1
            // 
            this.분ToolStripMenuItem1.Name = "분ToolStripMenuItem1";
            this.분ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.분ToolStripMenuItem1.Text = "5분";
            this.분ToolStripMenuItem1.Click += new System.EventHandler(this.minute5TSMI_Click);
            // 
            // 분ToolStripMenuItem2
            // 
            this.분ToolStripMenuItem2.Name = "분ToolStripMenuItem2";
            this.분ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.분ToolStripMenuItem2.Text = "10분";
            this.분ToolStripMenuItem2.Click += new System.EventHandler(this.minute10TSMI_Click);
            // 
            // 분ToolStripMenuItem3
            // 
            this.분ToolStripMenuItem3.Name = "분ToolStripMenuItem3";
            this.분ToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.분ToolStripMenuItem3.Text = "30분";
            this.분ToolStripMenuItem3.Click += new System.EventHandler(this.minute30TSMI_Click);
            // 
            // 분ToolStripMenuItem4
            // 
            this.분ToolStripMenuItem4.Name = "분ToolStripMenuItem4";
            this.분ToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.분ToolStripMenuItem4.Text = "60분";
            this.분ToolStripMenuItem4.Click += new System.EventHandler(this.minute60TSMI_Click);
            // 
            // 분ToolStripMenuItem5
            // 
            this.분ToolStripMenuItem5.Name = "분ToolStripMenuItem5";
            this.분ToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.분ToolStripMenuItem5.Text = "120분";
            this.분ToolStripMenuItem5.Click += new System.EventHandler(this.minute120TSMI_Click);
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.Timer_minute);
            // 
            // RandomRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 321);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.IsMinuteCheckBox);
            this.Controls.Add(this.StatePanel);
            this.Controls.Add(this.RestTimeTextBox);
            this.Controls.Add(this.TimeRangeTextBox);
            this.Controls.Add(this.TimeIntervalTextBox);
            this.Controls.Add(this.RestTimeLabel);
            this.Controls.Add(this.TimeIntervalLabel);
            this.Controls.Add(this.TimeRangeLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RandomRest";
            this.Text = "RandomRest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomRest_FormClosing);
            this.StatePanel.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label TimeRangeLabel;
        private System.Windows.Forms.TextBox TimeIntervalTextBox;
        private System.Windows.Forms.TextBox TimeRangeTextBox;
        private System.Windows.Forms.Panel StatePanel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ActivateTrayBarMenu;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label RestTimeLabel;
        private System.Windows.Forms.TextBox RestTimeTextBox;
        private System.Windows.Forms.CheckBox IsMinuteCheckBox;
        private System.Windows.Forms.Label TimeIntervalLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 타이머ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 분ToolStripMenuItem5;
        private System.Windows.Forms.Timer timer;
    }
}

