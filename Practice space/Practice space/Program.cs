using System;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //AVERAGE SCORE EXERCISE
            float avgScore = 0f;
            int numberOfInputs = 0; 
            int totalScore = 0;
            Console.WriteLine("Hello! Please enter some values between 0 and 20 and we will calculate the average.");
            Console.WriteLine("Remember to type -1 to stop inputs and get your average.");
            while (true)
            {
                Console.Write("Please enter on of your values here : ");
                string userInput = Console.ReadLine();
                int userInputConverted;
                if (int.TryParse(userInput, out userInputConverted)) {
                    if (userInputConverted >= 0 && userInputConverted <= 20)
                    {
                        totalScore += userInputConverted;
                        numberOfInputs++;
                    } else if (userInputConverted == -1) {
                        avgScore = totalScore / numberOfInputs;
                        Console.WriteLine("Thank you for using us.\nYour average score comes to " + avgScore);
                        break;
                    } else
                    {
                        Console.WriteLine("Looks like your input is not between 0 and 20. Please try again.");
                        //continue;
                    }
                } else
                {
                    Console.WriteLine("Sorry but we were unable to read your input. Please try again.");
                    //continue;
                }
            }
            Console.ReadLine();
        }
    }
}

