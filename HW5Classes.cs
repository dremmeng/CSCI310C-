// See https://aka.ms/new-console-template for more information
namespace HwClasses
{
    class Person
    {
        private string name;
        private int age;

        public Person(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }
    }
    class HW5Classes
    {
        public static void Main()
        {
            Person person1 = new Person("Kevin", 12);
            Person person2 = new Person("Steve", 15);
        }
    }
}