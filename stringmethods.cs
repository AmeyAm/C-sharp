using System;
using System.Reflection.Metadata;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = "Amey Am";
            String phoneno = "12345679";

            fullname= fullname.ToUpper();
            fullname= fullname.ToLower();
            Console.WriteLine(fullname);

            phoneno = phoneno.Replace("2", "-");
            Console.WriteLine(phoneno);

            String username = fullname.Insert(0, "@");
            Console.WriteLine(username);

            Console.WriteLine(fullname.Length);

            String firstname = fullname.Substring(0, 4);
            Console.WriteLine(firstname);

            String lastname = fullname.Substring(5, 2);
            Console.WriteLine(lastname);

            

        }
    }
}