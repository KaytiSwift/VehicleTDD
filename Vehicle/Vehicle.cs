using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Vehicle
    {
        //Fields
        private string make;
        private string model;
        private string year;
        private double engSize;
        private int rimSize;
        private string color;

        //Properties
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double EngSize
        {
            get { return this.engSize; }
            set { this.engSize = value; }
        }

        public int RimSize
        {
            get { return this.rimSize; }
            set { this.rimSize = value; }
        }

        public string VehColor
        {
            get { return this.color; }
            set { this.color = value; }
        }
        

        //Constructor
        public Vehicle()
        {
            //default constructor
        }

        public Vehicle(string make)
        {
            this.Make = make;
        }

        public Vehicle(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public Vehicle(string make, string model, string year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        //Methods
        public int GetMph(double distance, double time)
        {
            double mph = Math.Round(60 / (distance * time));
            return (int)mph;
        }

        public double GetMpg(double startODO, double endOdo, double TankSize )
        {
            double mpg = Math.Round(((startODO - endOdo) / TankSize) * 1000, 2);            
            return mpg;
        }
    }
}
