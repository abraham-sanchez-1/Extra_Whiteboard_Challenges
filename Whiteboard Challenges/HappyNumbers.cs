using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class HappyNumbers
    {
        //member variables
        int userInput;
        //constructor
        public HappyNumbers()
        {


        }
        //member methods
        public void ProgramRun()
        {
            Intro();
            HappyNumberChecker(userInput);
        }
        void Intro()
        {
            Console.WriteLine("This program will determine if input number is a happy number");
            Console.Write("Please enter integer");
            userInput = int.Parse(Console.ReadLine());
        }
        int HappyNumberLogic(int userinput)
        {
                int sum = 0;
                int individualNumber = 0;

                while (userinput > 0)
                {
                    individualNumber = userinput % 10;
                    sum += individualNumber * individualNumber;
                    userinput = userinput / 10;
                }
                return sum;
        }
        public void HappyNumberChecker(int numberToCheck)
        {
            while (numberToCheck != 1 && numberToCheck != 4)
            {
                numberToCheck = HappyNumberLogic(numberToCheck);
            }
            //Happy number will end if numberToCheck = 1
            if (numberToCheck == 1)
                Console.WriteLine(numberToCheck + " is a happy number :)");

            else if (numberToCheck == 4)
                Console.WriteLine("The number selected is a sad number :( you make computer and puppies sad");
        }


    }
}
