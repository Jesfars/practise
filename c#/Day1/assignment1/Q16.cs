using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
    

