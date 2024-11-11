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
    public partial class CustomerOrders : Form
    {
        public CustomerOrders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {
            ShowCustomerTripData();
        }

        private void ShowCustomerTripData()
        {
            Customer customer = UserManager.LoggedInCustomer;
            dataGridView1.DataSource = customer.ViewMyTrips(customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCustomerTripData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Hide();
        }
    }
}
