using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CB011943
{
    internal class UserManager
    {
        public static Customer LoggedInCustomer;
        public static Driver LoggedInDriver;

        public bool AuthenticateDriver(string username, string password)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            connection.Open();
            string query = "SELECT * FROM Driver WHERE Driver_name = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int DriverID = reader.GetInt32(0);
                string name = reader.GetString(1);
                string contact = reader.GetString(2);
                bool availability = reader.GetBoolean(3);
                LoggedInDriver = new Driver(name, contact, DriverID, availability, password);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AuthenticateCustomer(string username, string password)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            connection.Open();
            string query = "SELECT * FROM Customers WHERE Customer_name = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int CustomerID = reader.GetInt32(0);
                string name = reader.GetString(1);
                string contact = reader.GetString(2);
                LoggedInCustomer = new Customer(name, contact, CustomerID, password);
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool AuthenticateAdmin(string username, string password)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            connection.Open();
            string query = "SELECT * FROM admin_user WHERE username = @username AND password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
