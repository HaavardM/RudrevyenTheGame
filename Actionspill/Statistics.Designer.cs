namespace Actionspill
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.userTab = new System.Windows.Forms.TabPage();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.btn_gamstart = new System.Windows.Forms.Button();
            this.statisticsBox = new System.Windows.Forms.ListBox();
            this.btn_getuser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.scoreboardList = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.userTab.SuspendLayout();
            this.statisticsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.userTab);
            this.tabControl.Controls.Add(this.statisticsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(367, 632);
            this.tabControl.TabIndex = 0;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.currentUserLabel);
            this.userTab.Controls.Add(this.btn_gamstart);
            this.userTab.Controls.Add(this.statisticsBox);
            this.userTab.Controls.Add(this.btn_getuser);
            this.userTab.Controls.Add(this.label1);
            this.userTab.Controls.Add(this.usernameTextbox);
            this.userTab.Location = new System.Drawing.Point(4, 29);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(359, 599);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "Player";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currentUserLabel.ForeColor = System.Drawing.Color.Red;
            this.currentUserLabel.Location = new System.Drawing.Point(8, 90);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(322, 46);
            this.currentUserLabel.TabIndex = 11;
            this.currentUserLabel.Text = "EXAMPLEUSER";
            // 
            // btn_gamstart
            // 
            this.btn_gamstart.Location = new System.Drawing.Point(12, 536);
            this.btn_gamstart.Name = "btn_gamstart";
            this.btn_gamstart.Size = new System.Drawing.Size(339, 55);
            this.btn_gamstart.TabIndex = 10;
            this.btn_gamstart.Text = "Start game";
            this.btn_gamstart.UseVisualStyleBackColor = true;
            this.btn_gamstart.Click += new System.EventHandler(this.btn_gamstart_Click);
            // 
            // statisticsBox
            // 
            this.statisticsBox.FormattingEnabled = true;
            this.statisticsBox.ItemHeight = 20;
            this.statisticsBox.Items.AddRange(new object[] {
            ""});
            this.statisticsBox.Location = new System.Drawing.Point(8, 205);
            this.statisticsBox.MultiColumn = true;
            this.statisticsBox.Name = "statisticsBox";
            this.statisticsBox.ScrollAlwaysVisible = true;
            this.statisticsBox.Size = new System.Drawing.Size(343, 324);
            this.statisticsBox.TabIndex = 9;
            // 
            // btn_getuser
            // 
            this.btn_getuser.Location = new System.Drawing.Point(8, 55);
            this.btn_getuser.Name = "btn_getuser";
            this.btn_getuser.Size = new System.Drawing.Size(343, 32);
            this.btn_getuser.TabIndex = 8;
            this.btn_getuser.Text = "Select user";
            this.btn_getuser.UseVisualStyleBackColor = true;
            this.btn_getuser.Click += new System.EventHandler(this.btn_getuser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(8, 23);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(343, 26);
            this.usernameTextbox.TabIndex = 4;
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.scoreboardList);
            this.statisticsTab.Location = new System.Drawing.Point(4, 29);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(359, 599);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // scoreboardList
            // 
            this.scoreboardList.FormattingEnabled = true;
            this.scoreboardList.ItemHeight = 20;
            this.scoreboardList.Location = new System.Drawing.Point(8, 6);
            this.scoreboardList.MultiColumn = true;
            this.scoreboardList.Name = "scoreboardList";
            this.scoreboardList.Size = new System.Drawing.Size(348, 584);
            this.scoreboardList.Sorted = true;
            this.scoreboardList.TabIndex = 0;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 632);
            this.Controls.Add(this.tabControl);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.tabControl.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.statisticsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.ListBox statisticsBox;
        private System.Windows.Forms.Button btn_getuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.Button btn_gamstart;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.ListBox scoreboardList;
    }
}