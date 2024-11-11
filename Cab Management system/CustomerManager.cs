using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB011943
{
    internal class CustomerManager
    {
        //add customer to db with error handling
        public void AddCustomer(Customer customer)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Customers (Customer_name, Customer_contact, Password) VALUES (@Name, @Contact, @Password)", connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Contact", customer.Contact);
                command.Parameters.AddWithValue("@Password", customer.Password);
                command.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }


        }
        public void UpdateCustomerDetails(Customer customer)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Customers SET Customer_name = @Name, Customer_contact = @Contact WHERE Customer_id = @ID", connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Contact", customer.Contact);
                command.Parameters.AddWithValue("@ID", customer.Customer_ID);
                command.ExecuteNonQuery();
                MessageBox.Show("Customer Details Updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }


        }
    }
}
