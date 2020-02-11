using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class SequenceChecker
    {
        //member variable
        int[] array;
        int count;
        bool isSequence = true;
        //constructor
        public SequenceChecker()
        {
            //can add user input here for the array
            array = new int[] { 5, 3, 2, 1 };
            count = array.Length;
        }
        //member method
        public void ProgramRun()
        {
            Intro();
            Sort();
            isSequence = SequenceFollow();
            ProgramConclude();
        }
        public void Intro()
        {
            Console.WriteLine("This program will take an array of numbers an determine whether or not said numbers can form a sequence of incrementing integers");
            Console.WriteLine("Current Integers in the list are:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
        public void Sort()
        {
            int i, j;
            int N = count;
            for (j = count - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    int comparer = 0;
                    comparer = array[i].CompareTo(array[i + 1]);
                    if (comparer > 0)
                    {
                        Exchange(array, i, i + 1);
                    }
                }

            }
        }
        public bool SequenceFollow()
        {
            for (int i = 0; i < count - 1; i++)
            {
                if (!(array[i] == array[i + 1] - 1))
                {
                    return false;
                }

            }
            return true;

        }
        public void ProgramConclude()
        {
            Console.WriteLine("Program run has been completed:");
            Console.WriteLine("IsArraySequence: {0}", isSequence);
        }
        public static void Exchange(int[] list, int m, int n)
        {
            int placeholder;

            placeholder = list[m];
            list[m] = list[n];
            list[n] = placeholder;

        }
    }
}
