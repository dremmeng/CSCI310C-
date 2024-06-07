// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace HwClasses
{
    public class People
    {
        private string name;
        
        public void SetName(string _name)
        {
            this.name = _name;
        }
        
        public string GetName()
        {
            return this.name;
        }

    }
    public class Customer : People
    {
        private int cost;
        public void SetCost(int _cost)
        {
            this.cost = _cost;
        }
        public int GetCost()
        {
            return this.cost;
        }
        public double Tax()
        {
            return this.cost * .05;
        }
    }
    public class Employee : People
    {
        private int salary;
        public void SetSalary(int _salary)
        {
            this.salary = _salary;
        }
        public int GetSalary() 
        {
            return this.salary;
        }
        public double Tax()
        {
            return this.salary * .025;
        }
    }
    class HW5Classes
    {
        public static void Main()
        {
            Customer person1 = new Customer();
            person1.SetName("Kevin");
            Employee person2 = new Employee();
            person2.SetName("Steve");
            Console.WriteLine("Person 1's name is " + person1.GetName());
            Console.WriteLine("Person 2's name is " + person2.GetName());
            person1.SetCost(100);
            person2.SetSalary(100);
            Console.WriteLine("Person 1's tax is "+ person1.Tax());
            Console.WriteLine("Person 2's tax is " + person2.Tax());

        }
    }
}