// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

namespace HW2Conditionals
{
    class HW2Conditionals
    {
        public static void Main()
        {
            double income;
            income = Single.Parse(Console.ReadLine());
            double tax = 0;
            if (income < 10000)
            {
                tax = income * .05;
            }
            else if (income < 100000)
            {
                tax = income * .097;
            }
            else
            {
                tax = income * .14;
            }
            Console.WriteLine(tax.ToString("0.00"));
            Console.WriteLine("\r\n");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= num; i++)
            {
                for (int j = i; j > 0 ; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                for (int j = num; j > 0 ; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}