using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hello! Welcome to the TrueCoders Onboard bank experince!");

            user.IsAccountHolder = AskBoolQuestion("Are you an account holder?");

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Hello {user.FirstName}.");

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Welcome {user.FirstName} {user.LastName}.");


            user.PinNumber = AskPinQuestion($"What is your 3 digit personal Pin number ?");
            Console.WriteLine($"Thank you {user.FirstName}{user.LastName}. Your pin number is {user.PinNumber}.");
            Console.ReadLine();

        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var answer = AskQuestion(question + " (yes/no)");

                if ("yes" == answer)
                {
                    Console.WriteLine("That's great! We'll need to gather information about you to get started!");
                    return true;
                }

                else if ("no" == answer)
                {
                    Console.WriteLine("That is unfortunate.");
                    Console.ReadLine();
                    Environment.Exit(-1);
                    return false;
                }

                Console.WriteLine("You must answer yes or no");
            }
        }

        static int AskPinQuestion(string question)
        {
            while (true)
            {
                int length = 3;
                var response = AskQuestion(question);
                char[] ResponseArray = response.ToCharArray();
                bool PinBool = Int32.TryParse(response, out var num);

                if (!PinBool)
                {
                    Console.WriteLine($"Sorry that is not valid. " +
                            $"Please try again. Please enter your 3 digit personal Pin number.");
                    Console.ReadLine();
                    continue;
                }


                if (length > 3 && ResponseArray.Length != length)
                {
                    Console.WriteLine("Sorry, your pin must be 3 numbers.");
                    continue;
                }
                return num;

            }


        }



    }
}
