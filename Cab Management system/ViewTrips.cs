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
    public partial class ViewTrips : Form
    {
        public ViewTrips()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewTrips_Load(object sender, EventArgs e)
        {
            ShowTripsData();
        }

        private void ShowTripsData()
        {
            Admin admin = new Admin();
            dataGridView1.DataSource = admin.ViewOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTripsData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
