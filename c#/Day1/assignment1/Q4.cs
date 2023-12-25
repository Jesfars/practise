using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(" The number Even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
   

