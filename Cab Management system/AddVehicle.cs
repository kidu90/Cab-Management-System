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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VehicleManager vehicleManager = new VehicleManager();
            Vehicle vehicle = new Vehicle(textBox1.Text, textBox2.Text, true);
            vehicleManager.AddVehicle(vehicle);

        }
    }
}
