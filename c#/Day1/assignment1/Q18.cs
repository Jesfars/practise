using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            bool isPalindrome = IsPalindrome(word);

            if (isPalindrome)
            {
                Console.WriteLine("The word '{0}' is a palindrome.", word);
            }
            else
            {
                Console.WriteLine("The word '{0}' is not a palindrome.", word);
            }
        }

        static bool IsPalindrome(string word)
        {

            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            word = word.ToLower().Replace(" ", "");
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
    
