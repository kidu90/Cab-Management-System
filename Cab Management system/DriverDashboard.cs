﻿using System;
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
    public partial class DriverDashboard : Form
    {
        public DriverDashboard()
        {
            InitializeComponent();
        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {
            ShowDriverTrips();
        }

        private void ShowDriverTrips()
        {
            Driver driver = UserManager.LoggedInDriver;
            dataGridView1.DataSource = driver.ViewMyTrips(driver);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
