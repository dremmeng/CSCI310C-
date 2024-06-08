// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace Hw7Polymorphism
{
    public class Vehicle
    {
        private string name;
        private int maxspeed;
        private int price;
        private int torque;

        public void SetName(string _name)
        {
            this.name = _name;
        }
        public void SetTorque(int _torque)
        {
            this.torque = _torque;
        }
        public void SetPrice(int _price)
        {
            this.price = _price;
        }
        public int GetTorque()
        {
            return this.torque;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetMaxSpeed(int _maxspeed)
        {
            this.maxspeed = _maxspeed;
        }
        public int GetMaxSpeed()
        {
            return this.maxspeed;
        }
        public int GetPrice()
        {
            return this.price;
        }
        public double GetTax()
        {
            return this.price * .05;
        }
    }
    public class Car : Vehicle
    {
        public double GetTax()
        {
            return this.GetPrice() * .10;
    
        }
        
    }
    public class Truck : Vehicle
    {

       public double GetTax()
        {
            return this.GetPrice() * .15;
        }
    }
    class HW7Polymorphism
    {
        public static void Main()
        {
            Truck truck = new Truck();
            Car car = new Car();
            car.SetPrice(10000);
            truck.SetPrice(15000);

            car.GetTax();
            truck.GetTax();
        }
    }
}