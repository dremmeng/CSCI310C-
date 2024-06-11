// See https://aka.ms/new-console-template for more information
namespace HW9Interfaces
{
    interface animalSound
    {
        void animalSound(); // interface method
    }

    interface classification
    {
        void classification(); // interface method
    }

    // Implement multiple interfaces
    class Dog : animalSound, classification
    {
        public void animalSound()
        {
            Console.WriteLine("Dog goes bark");
        }
        public void classification()
        {
            Console.WriteLine("Dogs are mammals");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.animalSound();
            dog.classification();
        }
    }
}