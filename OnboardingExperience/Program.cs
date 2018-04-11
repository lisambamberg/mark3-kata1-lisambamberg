using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

             string AskQuestion(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            Console.WriteLine("Hello! We'll need to gather information about you to get started!");
            Console.ReadLine();

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Your name is {user.FirstName}");

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Your last name is {user.LastName}");

            
        }
    }
}
