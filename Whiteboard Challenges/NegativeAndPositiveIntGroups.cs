using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class NegativeAndPositiveIntGroups
    {
        //member methods
        int[] aggregateValues;
        int[] positiveValues;
        int[] negativeValues;
        int positiveCount;
        int negativeSum;

        //constructor
        public NegativeAndPositiveIntGroups()
        {
            aggregateValues = new int[0];
            positiveValues = new int[0];
            negativeValues = new int[0];

        }

        //member variables
        public void ProgramRun()
        {
            Intro();
            ReportList();
            Splitter();
            positiveCount = Count();
            negativeSum = Summation();
            ReportAndClose();
        }

        public void Intro() //introduces what each this program does and shows the values that are currently held in aggregate array
        {
            Console.WriteLine("This program is designed to decouple a list of positive and negative values and put them in seperate lists.\nProgram will then return count of positive values and sum of negative values");
            Console.WriteLine("You will now enter numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0}:", i + 1);
                int userInput = int.Parse(Console.ReadLine());
                aggregateValues = aggregateValues.Concat(new int[] { userInput }).ToArray();
            }

        }
        public void ReportList()
        {
            Console.Clear();
            Console.WriteLine("Current list is composed of the following items");
            foreach (var item in aggregateValues)
            {
                Console.WriteLine(item);
            }
        }
        public void Splitter()
        {
            for (int i = 0; i < aggregateValues.Length; i++)
            {
                if (aggregateValues[i] >= 0)
                {
                    positiveValues = positiveValues.Concat(new int[] { aggregateValues[i] }).ToArray();
                }
                else
                {
                    negativeValues = negativeValues.Concat(new int[] { aggregateValues[i] }).ToArray();
                }
            }
        }
        public int Count()
        {
            return positiveValues.Count();

        }
        public int Summation()
        {
            int sum = 0;
            foreach (var item in negativeValues)
            {
                sum += item;
            }
            return sum;
        }
        public void ReportAndClose()
        {
            Console.WriteLine("Program run completed:\nThe total count of positive values is {0}\nThe total sum of negative numbers is {1}", positiveCount, negativeSum);
        }
    }
}
