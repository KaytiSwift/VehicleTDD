using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Tests
{
    //Kayti Swift 9/19/18
    [TestFixture]
    public class VehicleTests
    {
        Vehicle vehicle = new Vehicle();

        [Test]
        public void Create_Veh_CTR_1_Input()
        {
            Vehicle vehicle = new Vehicle("Ford");
            string result = vehicle.Make;
            Assert.That(result, Is.EqualTo("Ford"));
        }

        [Test]
        public void Create_Veh_CTR_2_Input()
        {
            Vehicle vehicle = new Vehicle("Ford", "Bronco");
            string result = vehicle.Model;
            Assert.That(result, Is.EqualTo("Bronco"));
        }

        [Test]
        public void Create_Veh_CTR_3_Input()
        {
            Vehicle vehicle = new Vehicle("Ford", "Bronco", "1965");
            string result = vehicle.Year;
            Assert.That(result, Is.EqualTo("1965"));
        }

        [Test]
        public void Set_Engine_Size()
        {
            vehicle.EngSize = 5.0;
            double result = vehicle.EngSize;
            Assert.That(result, Is.EqualTo(5.0));
        }

        [Test]
        public void Set_Rim_Size()
        {
            vehicle.RimSize = 16;
            int result = vehicle.RimSize;
            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void Set_Veh_Color()
        {

            vehicle.VehColor = "Red";
            string result = vehicle.VehColor;
            Assert.That(result, Is.EqualTo("Red"));
        }

        [Test]
        public void Get_MPH()
        {
            int mph = vehicle.GetMph(7, 1);
            string result = mph + " MPH";
            Assert.That(result, Is.EqualTo("9 MPH"));
        }

        [Test]
        public void Get_MPG()
        {
            double mpg = vehicle.GetMpg(3579, 3117, 9251);
            string result = mpg + " MPG";
            Assert.That(result, Is.EqualTo("49.94 MPG"));
        }
    }
}
