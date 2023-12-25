using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int wordLength = word.Length;

            Console.WriteLine("The length of the word '{0}' is {1}.", word, wordLength);
        }
    }
}
    



