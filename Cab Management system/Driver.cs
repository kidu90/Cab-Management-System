using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CB011943
{
    internal class Driver : User
    {
        private int driver_ID;
        private bool availability;
        private string password;
        



        public int Driver_ID
        {
            get { return driver_ID; }
            set { driver_ID = value; }
        }

        public string DriverName
        {
            get { return Name; }
            set { Name = value; }
        }   

        public string DriverContact
        {
            get { return Contact; }
            set { Contact = value; }
        }
        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public Driver(string name, string contact, int driver_ID, bool availability, string password) : base(name, contact)
        {
            Driver_ID = driver_ID;
            DriverName = name;
            DriverContact = contact;
            Availability = availability;
            this.password = password;
        }
        // overloaded constructor
        public Driver (string name, string contact) : base(name, contact)
        {
            DriverName = name;
            DriverContact = contact;
            Availability = true;

        }

        public void UpdateAvailability(bool availability)
        {
            this.availability = availability;

        }

        public DataTable ViewMyTrips(Driver driver)
        {
            SqlConnection connection = new DbConnector().GetConnection();
            string query = "SELECT * FROM Orders WHERE Driver_id = @driver_ID";
            SqlDataAdapter adpt = new SqlDataAdapter(query, connection);
            adpt.SelectCommand.Parameters.AddWithValue("@driver_ID", driver.Driver_ID);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
    }
}
