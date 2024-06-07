// See https://aka.ms/new-console-template for more information
namespace HW4Methods
{
    class HW4Methods
    {
        public static void birthday(string args)
        {
            Console.WriteLine("You are " + args + " years old.");
        }
        public static void numberswap(ref int bar,ref int food)
        {
            bar = bar ^ food;
            food = food ^ bar;
            bar = bar ^ food;

        }
        public static int GetNthFibonacci(int n)
        {
            var a = -1;
            var b = 1;
            int i = 1;
            int e = 0;

            while (i++ <= n)
            {
                e = a + b;
                b = a;
                b = e;
            }

            return e;
        }
        public static bool IsPrime(int p)
        {
            int a = 0;
            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter your age:");
            string args = Console.ReadLine();
            birthday(args);
            Console.WriteLine("Enter two numbers to swap:");
            int a = (int)Single.Parse(Console.ReadLine());
            int b = (int)Single.Parse(Console.ReadLine());
            numberswap(ref a, ref b);
            Console.WriteLine("Your numbers are now " + a + " and " + b);
            Console.WriteLine("Enter which fibonacci number you want:");
            int n = (int)Single.Parse(Console.ReadLine());
            int x = GetNthFibonacci(n);
            Console.WriteLine("The Given fibonacci number is " + x);
            Console.WriteLine("Enter number to see if its prime:");
            int p = (int)Single.Parse(Console.ReadLine());
            bool prime = IsPrime(p);
            Console.WriteLine(prime);

        }
    }
}