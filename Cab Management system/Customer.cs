using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace CB011943
{
    internal class Customer : User
    {
        private int customer_ID;
        private string password;



        public int Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public Customer(string name, string contact, int customer_ID, string password) : base(name, contact)
        {
            Customer_ID = customer_ID;
            Name = name;
            Contact = contact;
            this.password = password;
        }

        public Customer(string name, string contact, string password) : base(name, contact)
        {
            Name = name;
            Contact = contact;
            Password = password;
        }


        
        public DataTable ViewMyTrips(Customer customer)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE Customer_id = @ID", connection);
                command.Parameters.AddWithValue("@ID", customer.Customer_ID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
         
        }
        
    }
}

