using LTDataLayer.ControlLayer;
using LTDataLayer.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchTimeWindows
{
    public partial class MainForm : Form
    {
        public PollInfo TodayPoll;
        private DataViewer frmDataViewer;
        public CountdownInfo Countdown;
        private List<UserForm> loggedUsers;
        private bool admin;

        public MainForm(bool? admin, bool? debug)
        {
            InitializeComponent();
            TodayPoll = PollsController.CurrentPoll();
            Countdown = new CountdownInfo();
            if (debug.HasValue && debug.Value)
            {
                Countdown.Hour = DateTime.Now.Hour;
                Countdown.Minute = DateTime.Now.AddSeconds(5 * 60).Minute;
            }
            else
            {
                Countdown.Hour = 12;
                Countdown.Minute = 00;
            }
            txtCntdownHour.Text = Countdown.Hour.ToString();
            txtCntdownMinute.Text = Countdown.Minute.ToString();
            loggedUsers = new List<UserForm>();
            tmrMain.Start();

            this.admin = admin.HasValue && admin.Value;
            if (!this.admin)
                tabMain.TabPages.Remove(tabAdmin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfo user = UsersController.Login(txtLogin.Text);
                UserForm newForm = new UserForm(user, TodayPoll, Countdown);
                loggedUsers.Add(newForm);
                newForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtLogin.Focus();
                txtLogin.SelectAll();
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Countdown.CountdownEnd)
                {
                    TodayPoll.Closed = true;
                    tmrMain.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmDataViewer == null)
                    frmDataViewer = new DataViewer();
                frmDataViewer.Show();
                frmDataViewer.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangePoll_Click(object sender, EventArgs e)
        {
            try
            {
                TodayPoll = PollsController.PollFromDate(dtpPollDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeCntdown_Click(object sender, EventArgs e)
        {
            try
            {
                int hour;
                int minute;

                if (Int32.TryParse(txtCntdownHour.Text, out hour))
                    Countdown.Hour = hour;
                else
                    txtCntdownHour.Text = Countdown.Hour.ToString();

                if (Int32.TryParse(txtCntdownMinute.Text, out minute))
                    Countdown.Minute = minute;
                else
                    txtCntdownMinute.Text = Countdown.Minute.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
