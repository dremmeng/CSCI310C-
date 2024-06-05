

namespace HW1types
{
    class HW1types
    {
        static void Main()
        {
            int a = 1;
            char b = 'a';
            decimal c = 1;
            string d = "string";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            a = 2;
            b = 'c';
            c = 2;
            d = "New";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            double length1 = 1;
            double length2 = 1;
            double length3 = 1;
            double s = length1 + length2 + length3;
            double area = Math.Sqrt(s * (s - length1) * (s - length2) * (s -= length3));
            Console.WriteLine(area);

        }
    }
}
