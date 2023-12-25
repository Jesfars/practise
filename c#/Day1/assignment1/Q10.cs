using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i * n);
            }
        }
    }
}
    

