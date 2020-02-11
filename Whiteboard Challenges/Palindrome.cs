using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class Palindrome
    {
        //member variable
        string userPalindrome;


        //constructor
        public Palindrome()
        {



        }
        public void ProgramRun()
        {
            Intro();
            DisplayResult(RunChecker());
        }
        public void Intro()
        {
            Console.WriteLine("Welcome to Palindrome Checker:\nA Palindrome is a word that when spelled backwards, is exactly the same as it was before");
            Console.WriteLine("Please enter word to for program to check:");
            userPalindrome = Console.ReadLine();
        }
        //member method
        public bool RunChecker()
        {
            bool isPalindrome = false;
            char[] charUserPalindrome = userPalindrome.ToCharArray();
            char[] reverseCharUserPalindrom = new char[charUserPalindrome.Length];
            for (int i = 0; i < charUserPalindrome.Length; i++)
            {
                reverseCharUserPalindrom[i] = charUserPalindrome[i];
            }
            Array.Reverse(reverseCharUserPalindrom);
            for (int i = 0; i < charUserPalindrome.Length; i++)
            {
                if (charUserPalindrome[i] == reverseCharUserPalindrom[i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    return isPalindrome;
                }
            }
            return isPalindrome;

        }
        public void DisplayResult(bool RunCheckerMethod)
        {
            if (RunCheckerMethod)
            {
                Console.WriteLine("Program check complete:\nThe word {0} is a palindrome", userPalindrome);
            }
            else
            {
                Console.WriteLine("Program check complete:\nThe word {0} is not a palindrome", userPalindrome);
            }

        }
    }
}
