using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaunchTimeClasses.ControlLayer;
using LaunchTimeClasses.DataLayer;

namespace LaunchTimeWindows
{
    public partial class UserForm : Form
    {
        private PollInfo _todayPoll;

        public PollInfo TodayPoll
        {
            get { return _todayPoll; }
            set { _todayPoll = value; }
        }
        public UserInfo User;
        public CountdownInfo Countdown;
        public UserForm(UserInfo user, PollInfo poll, CountdownInfo countdown)
        {
            User = user;
            _todayPoll = poll;
            Countdown = countdown;
            InitializeComponent();
            cbxRestaurants.DataSource = RestaurantsController.AvailableThisWeek(_todayPoll.Date);
            tmrCountdown.Start();
            this.Text += " - [" + User.Name + "]";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                TicketInfo ticket = new TicketInfo()
                {
                    Poll = TodayPoll,
                    Restaurant = (RestaurantInfo)cbxRestaurants.SelectedItem,
                    User = User
                };

                PollsController.Vote(ticket);

                cbxRestaurants.Enabled = false;
                btnSubmit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Countdown.CountdownEnd)
                {
                    if (TodayPoll.Winner != null)
                    {
                        lblChoosen.Text = TodayPoll.Winner.Name;
                        lblChoosen.Visible = true;
                        lblWait.Text = "The winner is";
                        //MessageBox.Show("The poll is closed, we have a winner!");
                        cbxRestaurants.Enabled = false;
                        btnSubmit.Enabled = false;
                        tmrCountdown.Stop();
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Normal;
                        }

                        this.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangeCurrentPoll(PollInfo newPoll)
        {
            TodayPoll = newPoll;
            ResetForm();
        }

        public void ResetForm()
        {
            cbxRestaurants.DataSource = null;
            cbxRestaurants.Refresh();
            cbxRestaurants.DataSource = RestaurantsController.AvailableThisWeek(_todayPoll.Date);
            lblChoosen.Text = "THE CHOSEN IS THIS";
            lblChoosen.Visible = false;
            lblWait.Text = "Wait . . .";
            cbxRestaurants.Enabled = true;
            btnSubmit.Enabled = true;
            tmrCountdown.Stop();
            tmrCountdown.Start();
        }
    }
}
