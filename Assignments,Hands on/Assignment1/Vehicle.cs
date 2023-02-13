using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Assignment
{
    internal class Vehicle
    {
        private string registrationNumber;
        private string driverName;
        private string vehicleType;
        private float costPerKM;

        //constructors
        public Vehicle() { }

        public Vehicle(string Number, string Name, string Type, float Cost)
        {
            registrationNumber = Number;
            driverName = Name;
            vehicleType = Type;
            costPerKM = Cost;
        }


        //Properties
        public string Number
        {
            set { registrationNumber = value; }
            get { return registrationNumber; }
        }
        public string Name
        {
            set { driverName = value; }
            get { return driverName; }
        }
        public string Type
        {
            set { vehicleType = value; }
            get { return vehicleType; }
        }
        public float Cost
        {
            set { costPerKM = value; }
            get { return costPerKM; }
        }



        public void Display()
        {
            Console.WriteLine("Enter Registration Number : "+Number);
            Console.WriteLine("Enter Driver Name : "+Name);
            Console.WriteLine("Enter Vehicle Type : "+Type);
            Console.WriteLine("Enter Cost Per KM : {0:0.0}",Cost);
        }
    }
}
