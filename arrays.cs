using System.Runtime.InteropServices;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] car = {"BMW", "Mustang", "Corvette"};

            car[3] = "tesla";

            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);

            for(int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }

            Console.ReadKey();
        }
    }
}