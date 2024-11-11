using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CB011943
{
    internal class Order
    {
        private string pickUpLocation;
        private string dropOffLocation;
        private int vehicleId;
        private int driverId;
        private DateTime dateTime;
        private int customerId;

        public string PickUpLocation
        {
            get { return pickUpLocation; }
            set { pickUpLocation = value; }
        }

        public string DropOffLocation
        {
            get { return dropOffLocation; }
            set { dropOffLocation = value; }
        }
        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        public int DriverId
        {
            get { return driverId; }
            set { driverId = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public Order(string pickUpLocation, string dropOffLocation, int vehicleId, int driverId, DateTime dateTime, int customerId)
        {
            PickUpLocation = pickUpLocation;
            DropOffLocation = dropOffLocation;
            VehicleId = vehicleId;
            DriverId = driverId;
            DateTime = dateTime;
            CustomerId = customerId;
        }

        public void SaveOrder(Order order)
        {
            DbConnector dbConnector = new DbConnector();
            SqlConnection sqlConnection = dbConnector.GetConnection(); 
            string query = "INSERT INTO Orders (pickup_location, dropoff_location, Vehicle_id, Driver_id, order_date, Customer_id) VALUES (@PickUpLocation, @DropOffLocation, @VehicleId, @DriverId, @DateTime, @CustomerId)";
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@PickUpLocation", order.PickUpLocation);
                sqlCommand.Parameters.AddWithValue("@DropOffLocation", order.DropOffLocation);
                sqlCommand.Parameters.AddWithValue("@VehicleId", order.VehicleId);
                sqlCommand.Parameters.AddWithValue("@DriverId", order.DriverId);
                sqlCommand.Parameters.AddWithValue("@DateTime", order.DateTime);
                sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }   
        }
    }
}
