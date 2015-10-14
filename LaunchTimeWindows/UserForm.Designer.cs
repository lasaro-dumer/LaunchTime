namespace LaunchTimeWindows
{
    partial class UserForm
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
            this.grpVote = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxRestaurants = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblChoosen = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.grpVote.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVote
            // 
            this.grpVote.Controls.Add(this.btnSubmit);
            this.grpVote.Controls.Add(this.cbxRestaurants);
            this.grpVote.Controls.Add(this.lblSelect);
            this.grpVote.Location = new System.Drawing.Point(12, 12);
            this.grpVote.Name = "grpVote";
            this.grpVote.Size = new System.Drawing.Size(326, 69);
            this.grpVote.TabIndex = 0;
            this.grpVote.TabStop = false;
            this.grpVote.Text = "Vote";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(226, 30);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxRestaurants
            // 
            this.cbxRestaurants.FormattingEnabled = true;
            this.cbxRestaurants.Location = new System.Drawing.Point(9, 32);
            this.cbxRestaurants.Name = "cbxRestaurants";
            this.cbxRestaurants.Size = new System.Drawing.Size(211, 21);
            this.cbxRestaurants.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(6, 16);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(96, 13);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select a restaurant";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblChoosen);
            this.grpResult.Controls.Add(this.lblWait);
            this.grpResult.Location = new System.Drawing.Point(12, 87);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(326, 100);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // lblChoosen
            // 
            this.lblChoosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoosen.Location = new System.Drawing.Point(6, 49);
            this.lblChoosen.Name = "lblChoosen";
            this.lblChoosen.Size = new System.Drawing.Size(311, 38);
            this.lblChoosen.TabIndex = 1;
            this.lblChoosen.Text = "THE CHOSEN IS THIS";
            this.lblChoosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoosen.Visible = false;
            // 
            // lblWait
            // 
            this.lblWait.Location = new System.Drawing.Point(9, 16);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(311, 33);
            this.lblWait.TabIndex = 0;
            this.lblWait.Text = "Wait . . .";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 211);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpVote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Vote";
            this.grpVote.ResumeLayout(false);
            this.grpVote.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVote;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbxRestaurants;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblChoosen;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}