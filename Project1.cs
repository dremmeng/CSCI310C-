using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Globalization;
namespace HW2Conditionals
{
    class HW2Conditionals
    {
        public static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Please enter year of birth:");
            int year = (int)Single.Parse(Console.ReadLine());
            Console.WriteLine("Please enter month of birth as a number:");
            int month = (int)Single.Parse(Console.ReadLine());
            Console.WriteLine("Please enter day of birth as a number:");
            int day = (int)Single.Parse(Console.ReadLine());
            int age = today.Year - year;
            DateTime dateofbirth = new DateTime(year, month, day);
            string date = dateofbirth.ToString();
            if (dateofbirth.Date > today.AddYears(-age))
            {
                age--;
            }
            if (dateofbirth.Year > today.Year + 150)
            {
                Console.WriteLine("Invalid Date");
            }
            Console.WriteLine("Your age is " + age + ".");
            if (dateofbirth.Day == today.Day && dateofbirth.Month == today.Month)
            {
                Console.WriteLine("It's your birthday! Happy Birthday!");

            }
            if (!DateTime.TryParse(date,out today))
            {
                Console.WriteLine("Invalid Date");
            }
            if ((dateofbirth.Month == 12 && dateofbirth.Day >= 22) || (dateofbirth.Month == 1 && dateofbirth.Day <= 20))
            {
                Console.WriteLine("Capricorn");
            }
            if ((dateofbirth.Month == 1 && dateofbirth.Day >= 21) || (dateofbirth.Month == 2 && dateofbirth.Day <= 19))
            {
                Console.WriteLine("Aquarius");
            }
            if ((dateofbirth.Month == 1 && dateofbirth.Day >= 20) || (dateofbirth.Month == 2 && dateofbirth.Day <= 20))
            {
                Console.WriteLine("Pisces");
            }
            if ((dateofbirth.Month == 3 && dateofbirth.Day >= 21) || (dateofbirth.Month == 4 && dateofbirth.Day <= 20))
            {
                Console.WriteLine("Aries");
            }
            if ((dateofbirth.Month == 4 && dateofbirth.Day >= 21) || (dateofbirth.Month == 5 && dateofbirth.Day <= 21))
            {
                Console.WriteLine("Taurus");
            }
            if ((dateofbirth.Month == 5 && dateofbirth.Day >= 22) || (dateofbirth.Month == 6 && dateofbirth.Day <= 21))
            {
                Console.WriteLine("Gemini");
            }
            if ((dateofbirth.Month == 6 && dateofbirth.Day >= 22) || (dateofbirth.Month == 7 && dateofbirth.Day <= 23))
            {
                Console.WriteLine("Cancer");
            }
            if ((dateofbirth.Month == 7 && dateofbirth.Day >= 24) || (dateofbirth.Month == 8 && dateofbirth.Day <= 23))
            {
                Console.WriteLine("Leo");
            }
            if ((dateofbirth.Month == 8 && dateofbirth.Day >= 24) || (dateofbirth.Month == 9 && dateofbirth.Day <= 23))
            {
                Console.WriteLine("Virgo");
            }
            if ((dateofbirth.Month == 9 && dateofbirth.Day >= 24) || (dateofbirth.Month == 10 && dateofbirth.Day <= 23))
            {
                Console.WriteLine("Libra");
            }
            if ((dateofbirth.Month == 10 && dateofbirth.Day >= 24) || (dateofbirth.Month == 11 && dateofbirth.Day <= 22))
            {
                Console.WriteLine("Scorpio");
            }
            if ((dateofbirth.Month == 11 && dateofbirth.Day >= 23) || (dateofbirth.Month == 12 && dateofbirth.Day <= 21))
            {
                Console.WriteLine("Saggitarius");
            }
            if (dateofbirth.Year % 12 == 0)
            {
                Console.WriteLine("Monkey");

            }
            if (dateofbirth.Year % 12 == 1)
            {
                Console.WriteLine("Rooster");

            }
            if (dateofbirth.Year % 12 == 2)
            {
                Console.WriteLine("Dog");

            }
            if (dateofbirth.Year % 12 == 3)
            {
                Console.WriteLine("Pig");

            }
            if (dateofbirth.Year % 12 == 4)
            {
                Console.WriteLine("Rat");

            }
            if (dateofbirth.Year % 12 == 5)
            {
                Console.WriteLine("Ox");

            }
            if (dateofbirth.Year % 12 == 6)
            {
                Console.WriteLine("Tiger");

            }
            if (dateofbirth.Year % 12 == 7)
            {
                Console.WriteLine("Rabbit");

            }
            if (dateofbirth.Year % 12 == 8)
            {
                Console.WriteLine("Dragon");

            }
            if (dateofbirth.Year % 12 == 9)
            {
                Console.WriteLine("Snake");

            }
            if (dateofbirth.Year % 12 == 10)
            {
                Console.WriteLine("Horse");

            }
            if (dateofbirth.Year % 12 == 11)
            {
                Console.WriteLine("Goat");
            }
        }
    }
}
