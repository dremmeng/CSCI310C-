using System;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HW15Linq
{
    class HW15Linq
    {
        static void Main()
        {
            List<int> randomNumbers1 = new List<int>();
            Random random = new Random();

            // Generate and add 10 random integers to the list
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(); // Generate a random integer
                randomNumbers1.Add(randomNumber); // Add it to the list
            }
            List<int> randomNumbers2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(); // Generate a random integer
                randomNumbers2.Add(randomNumber); // Add it to the list
            }
            var numQuery =
                from num in randomNumbers1
                where (num % 2) == 0
                select num;


            IEnumerable<int> filteringQuery =
                from num in randomNumbers1
                where num is < 3 or > 7
                select num;

            IEnumerable<int> orderingQuery =
                from num in randomNumbers1
                orderby num ascending
                select num;
            double average = randomNumbers1.Average();
            IEnumerable<int> concatenationQuery = randomNumbers1.Concat(randomNumbers2);
        }
    }
    
}