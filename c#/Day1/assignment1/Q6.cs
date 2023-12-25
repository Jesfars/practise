using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            int cel;
            Console.WriteLine("Enter the temperature in fahrenheit:");
            int far = int.Parse(Console.ReadLine());
            cel = ((far - 32) * (5 / 4));
            Console.WriteLine( "temperature in celisius="+cel);
        }
    }
}
    

