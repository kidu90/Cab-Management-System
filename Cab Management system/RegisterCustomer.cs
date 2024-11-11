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
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer(textBox1.Text, textBox2.Text, textBox3.Text);
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer);
            this.Hide();
        }
    }
}
