using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB011943
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageDrivers manageDrivers = new ManageDrivers();
            manageDrivers.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageVehicles manageVehicles = new ManageVehicles();
            manageVehicles.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewTrips viewTrips = new ViewTrips();
            viewTrips.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
