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
    public partial class EditCustomerDetails : Form
    {
        public EditCustomerDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = UserManager.LoggedInCustomer;
            customer.Name = textBox1.Text;
            customer.Contact = textBox2.Text;

            CustomerManager customerManager = new CustomerManager();
            customerManager.UpdateCustomerDetails(customer);

            ShowCustomerName(customer);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditCustomerDetails_Load(object sender, EventArgs e)
        {
            ShowCustomerName(UserManager.LoggedInCustomer);
        }

        private void ShowCustomerName(Customer customer)
        {
            labelCustName.Text = "Welcome, " + customer.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();   
            this.Hide();
        }
    }
}
