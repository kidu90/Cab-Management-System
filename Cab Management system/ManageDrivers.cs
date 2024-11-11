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
    public partial class ManageDrivers : Form
    {
        DriverManager driverManager;
        public ManageDrivers()
        {
            InitializeComponent();
            driverManager = new DriverManager();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddDriver addDriver = new AddDriver();
            addDriver.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverManager driverManager = new DriverManager();
            driverManager.DeleteDriver(Convert.ToInt32(textBox1.Text));
            ShowDriversData();
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            ShowDriversData();
        }

        private void ShowDriversData()
        {
            dataGridViewDrivers.DataSource = driverManager.ViewDrivers();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowDriversData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driverManager.UpdateDriverAvailability(Convert.ToInt32(textBox1.Text), true);
            ShowDriversData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            driverManager.UpdateDriverAvailability(Convert.ToInt32(textBox1.Text), false);
            ShowDriversData();
        }

        private void dataGridViewDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DriverManager driverManager = new DriverManager();
            label3.Text = driverManager.ViewDriverById(Convert.ToInt32(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
            
        }
    }
}
