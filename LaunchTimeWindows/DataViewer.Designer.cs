namespace LaunchTimeWindows
{
    partial class DataViewer
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
            this.gridRestaurants = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabsViews = new System.Windows.Forms.TabControl();
            this.tabRestaurants = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPolls = new System.Windows.Forms.TabPage();
            this.gridPolls = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pollInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.gridTickets = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restaurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantInfoBindingSource)).BeginInit();
            this.tabsViews.SuspendLayout();
            this.tabRestaurants.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            this.tabPolls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollInfoBindingSource)).BeginInit();
            this.tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRestaurants
            // 
            this.gridRestaurants.AllowUserToAddRows = false;
            this.gridRestaurants.AllowUserToDeleteRows = false;
            this.gridRestaurants.AutoGenerateColumns = false;
            this.gridRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRestaurants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.gridRestaurants.DataSource = this.restaurantInfoBindingSource;
            this.gridRestaurants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRestaurants.Location = new System.Drawing.Point(3, 3);
            this.gridRestaurants.Name = "gridRestaurants";
            this.gridRestaurants.ReadOnly = true;
            this.gridRestaurants.Size = new System.Drawing.Size(513, 382);
            this.gridRestaurants.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restaurantInfoBindingSource
            // 
            this.restaurantInfoBindingSource.DataSource = typeof(LaunchTimeClasses.ControlLayer.RestaurantInfo);
            // 
            // tabsViews
            // 
            this.tabsViews.Controls.Add(this.tabRestaurants);
            this.tabsViews.Controls.Add(this.tabUsers);
            this.tabsViews.Controls.Add(this.tabPolls);
            this.tabsViews.Controls.Add(this.tabTickets);
            this.tabsViews.Location = new System.Drawing.Point(12, 12);
            this.tabsViews.Name = "tabsViews";
            this.tabsViews.SelectedIndex = 0;
            this.tabsViews.Size = new System.Drawing.Size(527, 414);
            this.tabsViews.TabIndex = 1;
            // 
            // tabRestaurants
            // 
            this.tabRestaurants.Controls.Add(this.gridRestaurants);
            this.tabRestaurants.Location = new System.Drawing.Point(4, 22);
            this.tabRestaurants.Name = "tabRestaurants";
            this.tabRestaurants.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestaurants.Size = new System.Drawing.Size(519, 388);
            this.tabRestaurants.TabIndex = 0;
            this.tabRestaurants.Text = "Restaurants";
            this.tabRestaurants.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.gridUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(519, 388);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AutoGenerateColumns = false;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn});
            this.gridUsers.DataSource = this.userInfoBindingSource;
            this.gridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsers.Location = new System.Drawing.Point(3, 3);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.Size = new System.Drawing.Size(513, 382);
            this.gridUsers.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(LaunchTimeClasses.ControlLayer.UserInfo);
            // 
            // tabPolls
            // 
            this.tabPolls.Controls.Add(this.gridPolls);
            this.tabPolls.Location = new System.Drawing.Point(4, 22);
            this.tabPolls.Name = "tabPolls";
            this.tabPolls.Size = new System.Drawing.Size(519, 388);
            this.tabPolls.TabIndex = 3;
            this.tabPolls.Text = "Polls";
            this.tabPolls.UseVisualStyleBackColor = true;
            // 
            // gridPolls
            // 
            this.gridPolls.AllowUserToAddRows = false;
            this.gridPolls.AllowUserToDeleteRows = false;
            this.gridPolls.AutoGenerateColumns = false;
            this.gridPolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPolls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.dateDataGridViewTextBoxColumn,
            this.closedDataGridViewCheckBoxColumn,
            this.weekDataGridViewTextBoxColumn});
            this.gridPolls.DataSource = this.pollInfoBindingSource;
            this.gridPolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPolls.Location = new System.Drawing.Point(0, 0);
            this.gridPolls.Name = "gridPolls";
            this.gridPolls.ReadOnly = true;
            this.gridPolls.Size = new System.Drawing.Size(519, 388);
            this.gridPolls.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closedDataGridViewCheckBoxColumn
            // 
            this.closedDataGridViewCheckBoxColumn.DataPropertyName = "Closed";
            this.closedDataGridViewCheckBoxColumn.HeaderText = "Closed";
            this.closedDataGridViewCheckBoxColumn.Name = "closedDataGridViewCheckBoxColumn";
            this.closedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // weekDataGridViewTextBoxColumn
            // 
            this.weekDataGridViewTextBoxColumn.DataPropertyName = "Week";
            this.weekDataGridViewTextBoxColumn.HeaderText = "Week";
            this.weekDataGridViewTextBoxColumn.Name = "weekDataGridViewTextBoxColumn";
            this.weekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pollInfoBindingSource
            // 
            this.pollInfoBindingSource.DataSource = typeof(LaunchTimeClasses.ControlLayer.PollInfo);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.gridTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Size = new System.Drawing.Size(519, 388);
            this.tabTickets.TabIndex = 2;
            this.tabTickets.Text = "Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // gridTickets
            // 
            this.gridTickets.AllowUserToAddRows = false;
            this.gridTickets.AllowUserToDeleteRows = false;
            this.gridTickets.AutoGenerateColumns = false;
            this.gridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.Poll,
            this.Restaurant,
            this.User});
            this.gridTickets.DataSource = this.ticketInfoBindingSource;
            this.gridTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTickets.Location = new System.Drawing.Point(0, 0);
            this.gridTickets.Name = "gridTickets";
            this.gridTickets.ReadOnly = true;
            this.gridTickets.Size = new System.Drawing.Size(519, 388);
            this.gridTickets.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Poll
            // 
            this.Poll.DataPropertyName = "Poll";
            this.Poll.HeaderText = "Poll";
            this.Poll.Name = "Poll";
            this.Poll.ReadOnly = true;
            // 
            // Restaurant
            // 
            this.Restaurant.DataPropertyName = "Restaurant";
            this.Restaurant.HeaderText = "Restaurant";
            this.Restaurant.Name = "Restaurant";
            this.Restaurant.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // ticketInfoBindingSource
            // 
            this.ticketInfoBindingSource.DataSource = typeof(LaunchTimeClasses.ControlLayer.TicketInfo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Poll";
            this.dataGridViewTextBoxColumn1.HeaderText = "Poll";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Restaurant";
            this.dataGridViewTextBoxColumn2.HeaderText = "Restaurant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn3.HeaderText = "User";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 442);
            this.Controls.Add(this.tabsViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataViewer";
            this.ShowInTaskbar = false;
            this.Text = "DataViewer";
            this.Activated += new System.EventHandler(this.DataViewer_Activated);
            this.Enter += new System.EventHandler(this.DataViewer_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantInfoBindingSource)).EndInit();
            this.tabsViews.ResumeLayout(false);
            this.tabRestaurants.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.tabPolls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pollInfoBindingSource)).EndInit();
            this.tabTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRestaurants;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource restaurantInfoBindingSource;
        private System.Windows.Forms.TabControl tabsViews;
        private System.Windows.Forms.TabPage tabRestaurants;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.TabPage tabPolls;
        private System.Windows.Forms.DataGridView gridPolls;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pollInfoBindingSource;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.DataGridView gridTickets;
        private System.Windows.Forms.BindingSource ticketInfoBindingSource;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restaurant;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}