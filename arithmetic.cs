using System;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int friends = 5;

            friends ++ ;
            friends -= 1;
            friends /= 1;
            friends *= 1;
            */

            int friends = 10;
            int remainder = friends % 3;

            Console.WriteLine(friends);
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}