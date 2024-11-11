using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CB011943
{
    internal class DriverManager
    {
        SqlDataAdapter adpt;
        public void AddDriver(Driver driver)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Driver (Driver_name, Driver_contact, Driver_availability) VALUES (@Name, @Contact, @Availability)", connection);
                command.Parameters.AddWithValue("@Name", driver.DriverName); ;
                command.Parameters.AddWithValue("@Contact", driver.DriverContact);
                command.Parameters.AddWithValue("@Availability", driver.Availability);
                command.ExecuteNonQuery();
                MessageBox.Show("Driver Added Successfully");
            } catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateDriver(Driver driver)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Driver SET Driver_name = @Name, Driver_contact = @Contact, Driver_availability = @Availability WHERE Driver_ID = @ID", connection);
                command.Parameters.AddWithValue("@Name", driver.DriverName);
                command.Parameters.AddWithValue("@Contact", driver.DriverContact);
                command.Parameters.AddWithValue("@Availability", driver.Availability);
                command.Parameters.AddWithValue("@ID", driver.Driver_ID);
                command.ExecuteNonQuery();
                MessageBox.Show("Driver Updated Successfully");
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
        public void DeleteDriver(int Driver_ID)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Driver WHERE Driver_ID = @ID", connection);
                command.Parameters.AddWithValue("@ID", Driver_ID);
                command.ExecuteNonQuery();
                MessageBox.Show("Driver Deleted Successfully");
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

        public void UpdateDriverAvailability(int Driver_ID, bool availability)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Driver SET Driver_availability = @Availability WHERE Driver_ID = @ID", connection);
                command.Parameters.AddWithValue("@Availability", availability);
                command.Parameters.AddWithValue("@ID", Driver_ID);
                command.ExecuteNonQuery();
                MessageBox.Show("Driver Availability Updated Successfully");
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

        public DataTable ViewDrivers()
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Driver";
            adpt = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public DataTable ViewAvailableDrivers()
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Driver WHERE Driver_availability = 1";
            adpt = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        public string ViewDriverById(int Driver_ID)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Driver WHERE Driver_ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", Driver_ID);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //return driver name, id, contact, availability as a string
                return "Driver Details:\nDriver name: " + reader["Driver_name"].ToString() + "\n Driver ID: " + reader["Driver_ID"].ToString() + "\n Driver Contact: " + reader["Driver_contact"].ToString() + "\n Driver Availability: " + reader["Driver_availability"].ToString();

            }
            return null;
        }
}
}