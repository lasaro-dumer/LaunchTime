namespace LaunchTimeWindows
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.btnViewData = new System.Windows.Forms.Button();
            this.dtpPollDate = new System.Windows.Forms.DateTimePicker();
            this.btnChangePoll = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.txtCntdownHour = new System.Windows.Forms.TextBox();
            this.txtCntdownMinute = new System.Windows.Forms.TextBox();
            this.lblContdown = new System.Windows.Forms.Label();
            this.btnChangeCntdown = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(6, 35);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(213, 75);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(6, 6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(213, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "jack";
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(8, 67);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(204, 33);
            this.btnViewData.TabIndex = 2;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // dtpPollDate
            // 
            this.dtpPollDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPollDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPollDate.Location = new System.Drawing.Point(8, 12);
            this.dtpPollDate.Name = "dtpPollDate";
            this.dtpPollDate.Size = new System.Drawing.Size(100, 20);
            this.dtpPollDate.TabIndex = 3;
            // 
            // btnChangePoll
            // 
            this.btnChangePoll.Location = new System.Drawing.Point(114, 6);
            this.btnChangePoll.Name = "btnChangePoll";
            this.btnChangePoll.Size = new System.Drawing.Size(98, 26);
            this.btnChangePoll.TabIndex = 4;
            this.btnChangePoll.Text = "Change poll date";
            this.btnChangePoll.UseVisualStyleBackColor = true;
            this.btnChangePoll.Click += new System.EventHandler(this.btnChangePoll_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabUser);
            this.tabMain.Controls.Add(this.tabAdmin);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(233, 144);
            this.tabMain.TabIndex = 5;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.txtLogin);
            this.tabUser.Controls.Add(this.btnLogin);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(225, 118);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.btnChangeCntdown);
            this.tabAdmin.Controls.Add(this.lblContdown);
            this.tabAdmin.Controls.Add(this.txtCntdownMinute);
            this.tabAdmin.Controls.Add(this.txtCntdownHour);
            this.tabAdmin.Controls.Add(this.btnViewData);
            this.tabAdmin.Controls.Add(this.btnChangePoll);
            this.tabAdmin.Controls.Add(this.dtpPollDate);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(225, 118);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // txtCntdownHour
            // 
            this.txtCntdownHour.Location = new System.Drawing.Point(75, 40);
            this.txtCntdownHour.Name = "txtCntdownHour";
            this.txtCntdownHour.Size = new System.Drawing.Size(23, 20);
            this.txtCntdownHour.TabIndex = 5;
            this.txtCntdownHour.Text = "12";
            // 
            // txtCntdownMinute
            // 
            this.txtCntdownMinute.Location = new System.Drawing.Point(104, 40);
            this.txtCntdownMinute.Name = "txtCntdownMinute";
            this.txtCntdownMinute.Size = new System.Drawing.Size(23, 20);
            this.txtCntdownMinute.TabIndex = 6;
            this.txtCntdownMinute.Text = "00";
            // 
            // lblContdown
            // 
            this.lblContdown.AutoSize = true;
            this.lblContdown.Location = new System.Drawing.Point(8, 43);
            this.lblContdown.Name = "lblContdown";
            this.lblContdown.Size = new System.Drawing.Size(61, 13);
            this.lblContdown.TabIndex = 7;
            this.lblContdown.Text = "Countdown";
            // 
            // btnChangeCntdown
            // 
            this.btnChangeCntdown.Location = new System.Drawing.Point(133, 38);
            this.btnChangeCntdown.Name = "btnChangeCntdown";
            this.btnChangeCntdown.Size = new System.Drawing.Size(79, 23);
            this.btnChangeCntdown.TabIndex = 8;
            this.btnChangeCntdown.Text = "Change";
            this.btnChangeCntdown.UseVisualStyleBackColor = true;
            this.btnChangeCntdown.Click += new System.EventHandler(this.btnChangeCntdown_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 144);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch Time!";
            this.tabMain.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.DateTimePicker dtpPollDate;
        private System.Windows.Forms.Button btnChangePoll;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Button btnChangeCntdown;
        private System.Windows.Forms.Label lblContdown;
        private System.Windows.Forms.TextBox txtCntdownMinute;
        private System.Windows.Forms.TextBox txtCntdownHour;
    }
}

