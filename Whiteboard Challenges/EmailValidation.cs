using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenges
{
    class EmailValidation
    {
        //member validation
        string userInput;
        bool isEmailValid = false;
        List<string> emailEndings = new List<string>() { "edu", "com", "gov", "org", "net" };

        //constructor
        public EmailValidation()
        {

        }

        //member methods
        public void ProgramRun()
        {
            Intro();
            Validation(userInput);
            MessageToUser();
        }
        public void Intro()
        {
            Console.WriteLine("This program will check to see if user input is valid email address");
            Console.Write("Please enter email: ");
            userInput = Console.ReadLine();
        }
        public void Validation(string input)
        {
            char[] userEmail = input.ToCharArray();
            int emailIndexEnd = (userEmail.Count());
            int emailStartToDotCom = emailIndexEnd - 3;
            for (int i = 0; i < userEmail.Count(); i++)
            {
                if(userEmail[i] == '@' && i != 0)
                {
                            for (int j = i + 1; j < userEmail.Count(); j++)
                            {
                                if (userEmail[j] == '.')
                                {
                                    string ending = new string(userEmail.Skip(j + 1).Take(emailIndexEnd - emailStartToDotCom).ToArray());
                                    if (emailEndings.Contains(ending))
                                    {
                                        isEmailValid = true;
                                    }
                            break;
                                }
                            }
             break;
                }
            }
            
        }
        public void MessageToUser()
        {
            Console.WriteLine("Program has finished running, validity status of email is: {0}", isEmailValid);
        }


    }
}
