using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class ReturnHighLow
    {
        //member variable
        int[] intUserList;
        int maxValue, minValue;
        string userInput;

        //constructor
        public ReturnHighLow()
        {
            intUserList = new int[0];



        }

        //member methods
        public void ProgramRun()
        {
            Intro();
            IntArrayCreation();
            ReportOut();

        }
        public void Intro()
        {
            Console.WriteLine("This program is designed to take in a user input of strings and turn it into a list of integers.\nThis will then return the highest and lowest values in said list");
            Console.WriteLine("Please enter values (leave one space between separate values Example: 1 31 4 10 2):");
            userInput = Console.ReadLine();
        }
        public void IntArrayCreation()
        {
            string[] result = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < result.Length; i++)
            {
                intUserList = intUserList.Concat(new int[] { int.Parse(result[i]) }).ToArray();
            }
            maxValue = intUserList.Max();
            minValue = intUserList.Min();
        }
        public void ReportOut()
        {
            Console.WriteLine("Program run has been completed:\nMax value is {0}\nMin value is {1}", maxValue, minValue);
            Console.ReadKey();
        }
    }
}
