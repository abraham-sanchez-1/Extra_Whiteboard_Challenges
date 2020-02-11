using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class TargetFinder
    {
        //Member Variables
        int targetNumber;
        int[] intArray;
        int[] arrayIndexMatches;

        //Constructor
        public TargetFinder()
        {
            intArray = new int[15] { 1, 3, 4, 5, 7, 9, 10, 11, 13, 15, 16, 18, 21, 22, 23 };
        }

        //Member Variables
        public void ProgramRun()
        {
            Intro();
            Selection();
            Message(FindMatches());
        }

        public void Intro()
        {
            Console.WriteLine("Below is the list of integers available");
            foreach (var integer in intArray)
            {
                Console.WriteLine(integer);
            }
        }
        public void Selection()
        {
            Console.WriteLine("Please select a target, this program will identify index locations which when added, will total the same amount as your target");
            targetNumber = int.Parse(Console.ReadLine());
        }
        public bool FindMatches()
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = 0; j < intArray.Length - 1; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        continue;
                    }
                    if (intArray[i] + intArray[j] == targetNumber)
                    {
                        arrayIndexMatches = new int[2] { i, j };
                        return true;
                    }
                }
            }
            Console.WriteLine("No matches were found");
            return false;
        }
        public void Message(bool choice)
        {
            if (choice)
            {
                Console.WriteLine("We have a match\nThe two index numbers of the array which add up to the target are:\n" +
                    "{0} and {1} ", arrayIndexMatches[0], arrayIndexMatches[1]);
                Console.WriteLine("Actual figures at said indeces are: {0} and {1}", intArray[arrayIndexMatches[0]], intArray[arrayIndexMatches[1]]);
            }
            else
            {
                Console.WriteLine("No matches were found");
            }
        }
    }
}
