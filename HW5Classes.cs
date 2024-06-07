// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace HwClasses
{
    public class Person
    {
        private string name;
        private int age;
        public void SetAge(int _age)
        {
            this.age = _age;
        }
        public void SetName(string _name) 
        {
            this.name = _name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetName() 
        {
            return this.name;
        }

    }
    class HW5Classes
    {
        public static void Main()
        {
            Person person1 = new Person();
            person1.SetAge(15);
            person1.SetName("Kevin");
            Person person2 = new Person();
            person2.SetAge(12);
            person2.SetName("Steve");
            Console.WriteLine("Person 1's name is " + person1.GetName());
            Console.WriteLine("Person 2's name is " + person2.GetName());
            Console.WriteLine("Person 1's age is " + person1.GetAge());
            Console.WriteLine("Person 2's age is " + person2.GetAge());

        }
    }
}