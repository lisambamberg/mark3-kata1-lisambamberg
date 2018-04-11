using System;
using System.Collections.Generic;
using System.Text;

namespace OnboardingExperience
{
    public class User
    {
        public string FirstName;
        public string LastName; 
        
        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        
    }
}
