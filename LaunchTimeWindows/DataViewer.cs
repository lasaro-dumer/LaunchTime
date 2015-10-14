using LTDataLayer.ControlLayer;
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
    public partial class DataViewer : Form
    {
        public DataViewer()
        {
            InitializeComponent();
            RefreshData();
        }

        private void DataViewer_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            gridRestaurants.DataSource = null;
            gridUsers.DataSource = null;
            gridPolls.DataSource = null;
            gridTickets.DataSource = null;
            gridRestaurants.DataSource = RestaurantsController.ListAll();
            gridUsers.DataSource = UsersController.ListAll();
            gridPolls.DataSource = PollsController.ListAll();
            gridTickets.DataSource = TicketsController.ListAll();
            gridRestaurants.Refresh();
            gridUsers.Refresh();
            gridPolls.Refresh();
            gridTickets.Refresh();
        }
    }
}
