using System;
using System.IO.Compression;

namespace output
{
    class Program{
        static void Main(string[] args)
        {
         int x; //declaration
         x = 123;

         int y = 321;

         int z = x + y;

         int age = 21;

         double height = 300.54;

         bool alive = true;

         Console.WriteLine("your age is " + age);

         Console.WriteLine("your height is " + height + " cm");

         Console.WriteLine("Are you alive?" + alive);

         Console.WriteLine(x);
         Console.WriteLine(y);
         Console.WriteLine(z);

         Console.ReadKey();

        }
    }
}