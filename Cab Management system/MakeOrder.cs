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
    public partial class MakeOrder : Form
    {
        public MakeOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DriverManager driverManager = new DriverManager();
            VehicleManager vehicleManager = new VehicleManager();

            string PickUpLocation = textBoxLocation.Text;
            string DropOffLocation =dropOffLocation.Text;
            DateTime dateTime = dateTimePicker1.Value;
            int DriverId = Convert.ToInt32(textBoxDriverId.Text);
            int VehicleId = Convert.ToInt32(textBoxVehicleId.Text);
            int CustomerId = UserManager.LoggedInCustomer.Customer_ID;
            Order order = new Order(PickUpLocation, DropOffLocation, VehicleId, DriverId, dateTime, CustomerId);

            driverManager.UpdateDriverAvailability(DriverId, false);
            vehicleManager.UpdateVehicleAvailability(VehicleId, false);
            order.SaveOrder(order);

            ShowData();
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            DriverManager driverManager = new DriverManager();
            VehicleManager vehicleManager = new VehicleManager();   
            availableCars.DataSource = vehicleManager.ViewAvailableVehicles();
            availableDrivers.DataSource = driverManager.ViewAvailableDrivers();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Hide();
        }
    }
}
