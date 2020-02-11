using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class BriefCaseLock
    {
        //member variable
        int[] unlockCombination = new int[4] { 3, 5, 6, 2 };
        int[] currentLockSetting = new int[4] { 2, 6, 5, 3 };
        int count;
        //constructor
        public BriefCaseLock()
        {

        }

        //member method
        public void ProgramRun()
        {
            Intro();
            Calculate();
        }
        public void Intro()
        {
            Console.WriteLine("This program will find shortest route to open a four digit rolling lock(assuming we know the combination)\n");
            Console.WriteLine("Lock combination code is: {0}{1}{2}{3}\n", unlockCombination[0], unlockCombination[1], unlockCombination[2], unlockCombination[3]);
            Console.WriteLine("Lock is currently at: {0}{1}{2}{3}\n", currentLockSetting[0], currentLockSetting[1], currentLockSetting[2], currentLockSetting[3]);
        }
        public void Calculate()
        {
            //shorter distance will occupy values below
            int firstValue, secondValue, thirdValue, fourthValue;

            firstValue = ChooseSmallerCount(PositiveDirection(0), NegativeDirection(0));
            secondValue = ChooseSmallerCount(PositiveDirection(1), NegativeDirection(1));
            thirdValue = ChooseSmallerCount(PositiveDirection(2), NegativeDirection(2));
            fourthValue = ChooseSmallerCount(PositiveDirection(3), NegativeDirection(3));

            count = AddFour(firstValue, secondValue, thirdValue, fourthValue);
            Conclude();
        }
        public int ChooseSmallerCount(int firstNumber, int secondNumber)
        {
            if (firstNumber <= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        public int NegativeDirection(int selection)
        {
            int currentCode = currentLockSetting[selection];
            int desiredCode = unlockCombination[selection];
            int count = 0;
            while (!(currentCode == desiredCode))
            {
                currentCode--;
                count++;
                if (currentCode == -1)
                {
                    currentCode = 9;
                }

            }
            return count;
        }
        public int PositiveDirection(int selection)
        {
            int currentCode = currentLockSetting[selection];
            int desiredCode = unlockCombination[selection];
            int count = 0;
            while (!(currentCode == desiredCode))
            {
                currentCode++;
                count++;
                if (currentCode == 10)
                {
                    currentCode = 0;
                }

            }
            return count;
        }
        public int AddFour(int one, int two, int three, int four)
        {
            int result = one + two + three + four;
            return result;
        }
        public void Conclude()
        {
            Console.WriteLine("Program has calculated shortest route to solving lock:\nResult is {0} turns", count);
        }

    }
}
