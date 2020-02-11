﻿using System;
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
            for (int i = 0; i < userEmail.Count(); i++)
            {
                if(userEmail[i] == '@')
                {
                    if (userEmail[i-1] != null)
                    {
                        for (int x = i; x < userEmail.Count(); x++)
                        {
                            string charToString;
                            charToString = new string(userEmail, (userEmail.Count())-3, userEmail.Count());
                            if (charToString == ".com" ) 
                            {
                                isEmailValid = true;
                            }
                        }
                    }
                }
            }
            
        }
        public void MessageToUser()
        {
            Console.WriteLine("Program has finished running, valid status of email is: {0}", isEmailValid);
        }


    }
}