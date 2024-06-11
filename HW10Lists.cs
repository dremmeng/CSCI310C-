// See https://aka.ms/new-console-template for more information
using System.Collections;
using System;
using System.Collections.Generic;

namespace HW10Lists
{
    public class HW10lists
    { 
        static void binaryInsert(List<int> list1, int i)
        {
            int index = list1.BinarySearch(i);
            if (index == -1)
            {
                index = 0;
            }
            list1.Insert(index, i);
        }
        public static void Main()
        {

            List<Double> list2 = new List<Double>();
            int index = 0;
            Random rnd = new Random();
            List<int> list1 = new List<int>();
            while (true)
            {
                int randomNum = rnd.Next(11, 100);
                list1.Add(randomNum);
                if (index == 10)
                {
                    break;
                }
                index++;
            }
            while (true)
            {
                double randomNum = rnd.NextDouble();
                list2.Add(randomNum);
                if (index == 10)
                {
                    break;
                }
                index++;
            }

            Console.WriteLine("Enter number to insert:");
            int i = (int)Single.Parse(Console.ReadLine());
            list1.Sort();
            binaryInsert(list1, i);
        }
    }
    
}
