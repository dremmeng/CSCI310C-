using System;
using System.Drawing;
namespace HW14Delegates
{
    class Circle
    {

        public delegate void circumference(double radius);
        public delegate void area(double radius);

        
        public void writecircumference(double radius)
        {
            Console.WriteLine("Circumference is "+ radius *Math.PI );
        }
        public void writearea(double radius)
        {
            Console.WriteLine("Area is " + radius * radius * Math.PI);
        }
        static void DoSomething(int i)
        {
            Console.WriteLine(i);
        }

        static double CalculateSomething(int i)
        {
            return (double)i / 2;
        }
        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
        public static void Main()
        {

            Circle obj = new Circle();
            circumference del_obj1 = new circumference(obj.writecircumference);
            area del_obj2 = new area(obj.writearea);
            del_obj1(1.0);
            del_obj2(1.0);
            Action<int> myAction = new Action<int>(DoSomething);
            myAction(123);           
            Func<int, double> myFunc = new Func<int, double>(CalculateSomething);
            Console.WriteLine(myFunc(5));
            Point[] points = { new Point(100, 200),
                         new Point(150, 250), new Point(250, 375),
                         new Point(275, 395), new Point(295, 450) };
            Predicate<Point> predicate = FindPoints;
            Point first = Array.Find(points, predicate);
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);


        }
    }

}