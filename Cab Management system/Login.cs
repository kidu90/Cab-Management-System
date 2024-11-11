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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            bool authenticated = userManager.AuthenticateCustomer(textBox1.Text, textBox2.Text);
            if (authenticated)
            {
                CustomerDashboard customerDashboard = new CustomerDashboard();
                customerDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            bool authenticated = userManager.AuthenticateAdmin(textBox1.Text, textBox2.Text);
            if (authenticated)
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            bool authenticated = userManager.AuthenticateDriver(textBox1.Text, textBox2.Text);
            if (authenticated)
            {
                DriverDashboard driverDashboard = new DriverDashboard();
                driverDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterCustomer registerCustomer = new RegisterCustomer();
            registerCustomer.Show();

        }
    }
}
