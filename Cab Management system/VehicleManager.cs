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
    internal class VehicleManager
    {
        SqlDataAdapter adpt;
        public void AddVehicle (Vehicle vehicle)
        {
            DbConnector dbConnector = new DbConnector();
            SqlConnection connection = dbConnector.GetConnection();
            string query = "INSERT INTO Vehicle (vehicle_model, vehicle_plate_number, vehicle_availability) VALUES (@CarModel, @PlateNumber, @Availability)";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarModel", vehicle.CarModel);
                command.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                command.Parameters.AddWithValue("@Availability", vehicle.Availability);
                command.ExecuteNonQuery();
                MessageBox.Show("Vehicle Added Successfully");
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
        public void DeleteVehicle(int vehicle_id)
        {
            DbConnector dbConnector = new DbConnector();
            SqlConnection connection = dbConnector.GetConnection();
            string query = "DELETE FROM Vehicle WHERE vehicle_id = @ID";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", vehicle_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Vehicle Deleted Successfully");
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

        public void UpdateVehicleAvailability(int vehicle_id, bool availability)
        {
            DbConnector dbConnector = new DbConnector();
            SqlConnection connection = dbConnector.GetConnection();
            string query = "UPDATE Vehicle SET vehicle_availability = @Availability WHERE vehicle_id = @ID";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Availability", availability);
                command.Parameters.AddWithValue("@ID", vehicle_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Vehicle Availability Updated Successfully");
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

        public DataTable ViewVehicles()
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Vehicle";
            adpt = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public DataTable ViewAvailableVehicles()
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Vehicle WHERE vehicle_availability = 1";
            adpt = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public string ViewVehicleById(int vehicle_id)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Vehicle WHERE vehicle_id = @ID";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", vehicle_id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //return the vehicle details
                    return "Vehicle ID: " + reader["vehicle_id"].ToString() + "\n" +
                        "Vehicle Model: " + reader["vehicle_model"].ToString() + "\n" +
                        "Vehicle Plate Number: " + reader["vehicle_plate_number"].ToString() + "\n" +
                        "Vehicle Availability: " + reader["vehicle_availability"].ToString();

                }
                else
                {
                    return "Vehicle not found";
                }
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
