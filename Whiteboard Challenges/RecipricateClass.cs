using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class RecipricateClass
    {
        //member variable
        string userInput;
        //constructor
        public RecipricateClass()
        {

        }

        //member method
        public void ProgramRun()
        {
            Intro();
            UserInput();
            Compute();
        }
        public void Intro()
        {
            Console.WriteLine("This program is designed to take in user input and return the recipricated value after first reversing the order of user input.");
            Console.WriteLine("Please enter value:");
        }
        public void UserInput()
        {
            userInput = Console.ReadLine();
            Console.WriteLine("\nUser has selected: {0}\n", userInput);
            Console.ReadKey();
        }
        public void Compute()
        {
            double recipricatedValue;
            char[] charUserInput = userInput.ToCharArray();
            Array.Reverse(charUserInput);
            double doubleUserInput = TurnCharArrayToDouble(charUserInput);
            recipricatedValue = Recipricate(doubleUserInput);
            Console.WriteLine("Program has computed value\n");
            Console.WriteLine("Result: {0}", recipricatedValue);

        }
        public double Recipricate(double value)
        {
            double result = 1 / value;
            return result;
        }
        public double TurnCharArrayToDouble(char[] array)
        {
            string stringValues = new string(array);
            double doubleValues = Convert.ToDouble(stringValues);
            return doubleValues;
        }
        public double Round()
        {
            return 2;
        }
    }
}
