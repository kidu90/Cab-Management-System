using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB011943
{
    internal class Vehicle
    {
        private int vehicle_ID;
        private string model;
        private string plateNo;
        private bool availability;


        public int VehicleID
        {
            get { return vehicle_ID; }
            set { vehicle_ID = value; }
        }

        public string CarModel
        {
            get { return model; }
            set { model = value; }
        }

        public string PlateNumber
        {
            get { return plateNo; }
            set { plateNo = value; }
        }

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public Vehicle(string model, string plateNo, bool availability)
        {
            CarModel = model;
            PlateNumber = plateNo;
            Availability = availability;
        }

        public void UpdateAvailability(bool availability)
        {
            this.availability = availability;
        }
    }


   

   
}
