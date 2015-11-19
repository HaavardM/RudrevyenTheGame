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
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(245, 411);
            this.tabControl.TabIndex = 0;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.label2);
            this.userTab.Controls.Add(this.currentUserLabel);
            this.userTab.Controls.Add(this.btn_gamstart);
            this.userTab.Controls.Add(this.statisticsBox);
            this.userTab.Controls.Add(this.btn_getuser);
            this.userTab.Controls.Add(this.label1);
            this.userTab.Controls.Add(this.usernameTextbox);
            this.userTab.Location = new System.Drawing.Point(4, 22);
            this.userTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTab.Size = new System.Drawing.Size(237, 385);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "Player";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currentUserLabel.ForeColor = System.Drawing.Color.Red;
            this.currentUserLabel.Location = new System.Drawing.Point(5, 58);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(0, 31);
            this.currentUserLabel.TabIndex = 11;
            // 
            // btn_gamstart
            // 
            this.btn_gamstart.Location = new System.Drawing.Point(8, 348);
            this.btn_gamstart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gamstart.Name = "btn_gamstart";
            this.btn_gamstart.Size = new System.Drawing.Size(226, 36);
            this.btn_gamstart.TabIndex = 10;
            this.btn_gamstart.Text = "Start game";
            this.btn_gamstart.UseVisualStyleBackColor = true;
            this.btn_gamstart.Click += new System.EventHandler(this.btn_gamstart_Click);
            // 
            // statisticsBox
            // 
            this.statisticsBox.FormattingEnabled = true;
            this.statisticsBox.Items.AddRange(new object[] {
            ""});
            this.statisticsBox.Location = new System.Drawing.Point(5, 133);
            this.statisticsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statisticsBox.MultiColumn = true;
            this.statisticsBox.Name = "statisticsBox";
            this.statisticsBox.ScrollAlwaysVisible = true;
            this.statisticsBox.Size = new System.Drawing.Size(230, 212);
            this.statisticsBox.TabIndex = 9;
            // 
            // btn_getuser
            // 
            this.btn_getuser.Location = new System.Drawing.Point(5, 36);
            this.btn_getuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_getuser.Name = "btn_getuser";
            this.btn_getuser.Size = new System.Drawing.Size(229, 21);
            this.btn_getuser.TabIndex = 8;
            this.btn_getuser.Text = "Select user";
            this.btn_getuser.UseVisualStyleBackColor = true;
            this.btn_getuser.Click += new System.EventHandler(this.btn_getuser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(5, 15);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(230, 20);
            this.usernameTextbox.TabIndex = 4;
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.scoreboardList);
            this.statisticsTab.Location = new System.Drawing.Point(4, 22);
            this.statisticsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statisticsTab.Size = new System.Drawing.Size(237, 385);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // scoreboardList
            // 
            this.scoreboardList.FormattingEnabled = true;
            this.scoreboardList.Location = new System.Drawing.Point(5, 4);
            this.scoreboardList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreboardList.MultiColumn = true;
            this.scoreboardList.Name = "scoreboardList";
            this.scoreboardList.Size = new System.Drawing.Size(233, 381);
            this.scoreboardList.Sorted = true;
            this.scoreboardList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "User scores";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 411);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
    }
}