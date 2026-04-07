using System;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.99;
            double y = 5;
            
            
            //double a = Math.Pow(x, 2);
            //double a = Math.Sqrt(x);
            //double a = Math.Abs(x);
            //double a = Math.Round(x);
            //double a = Math.Ceiling(x);
            //double a = Math.Floor(x);
            double a = Math.Max(x, y);
            double a = Math.Min(x, y);

            Console.WriteLine(a);


            Console.ReadKey();
        }
    }
}