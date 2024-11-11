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
    public partial class ManageVehicles : Form
    {
        public ManageVehicles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle();
            addVehicle.Show();
        }

        private void ManageVehicles_Load(object sender, EventArgs e)
        {
            ShowVehicleData();
        }

        private void ShowVehicleData()
        {
           VehicleManager vehicleManager = new VehicleManager();
            dataGridView1.DataSource = vehicleManager.ViewVehicles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowVehicleData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VehicleManager vehicleManager = new VehicleManager();
            vehicleManager.DeleteVehicle(Convert.ToInt32(textBox1.Text));
            ShowVehicleData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VehicleManager vehicleManager = new VehicleManager();
            vehicleManager.UpdateVehicleAvailability(Convert.ToInt32(textBox1.Text), true);
            ShowVehicleData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VehicleManager vehicleManager = new VehicleManager();
            vehicleManager.UpdateVehicleAvailability(Convert.ToInt32(textBox1.Text), false);
            ShowVehicleData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VehicleManager vehicleManager = new VehicleManager();
            label2.Text = vehicleManager.ViewVehicleById(Convert.ToInt32(textBox1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
    }
}
