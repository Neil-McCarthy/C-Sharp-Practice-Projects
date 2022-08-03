using System;

namespace HelloWorld
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //BASIC LOGIN SYSTEM
            string existingUser = "Neil McCarthy";
            string existingPassword = "Password01";
            string enteredUsername, enteredPassword;
            Console.WriteLine("Hello and welcome to the site.\nWould you like to:\n\n1) Sign-up\n\nOr\n\n2) Log-in\n\n");
            Console.WriteLine("Please enter the number corresponding to the answers above : ");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "1")
            {
                Console.WriteLine("Graet to meet you!\nPlease enter your username here : ");
                enteredUsername = Console.ReadLine();
                if (enteredUsername != existingUser)
                {
                    Console.WriteLine("\nPlease enter your password here : ");
                    enteredPassword= Console.ReadLine();
                    Console.WriteLine("\nPlease re-enter your password here to confirm : ");
                    string enteredPasswordCheck = Console.ReadLine();
                    if (enteredPassword == enteredPasswordCheck)
                    {
                        Console.WriteLine("Hi " + enteredUsername + "!\nWelcome to the site.\nWe currently offer no services. Goodbye.");
                    } else
                    {
                        Console.WriteLine("Sorry but it appears those passwords don't match.\nPlease try again.\n\n");
                    }
                } else
                {
                    Console.WriteLine("Apologies but it seems like that username is already taken.\nWould you like to try again?\n\ny/n :");
                    string tryAgain = Console.ReadLine();
                }
            } else if (userAnswer == "2")
            {
                Console.WriteLine("Please enter your username here : ");
                enteredUsername = Console.ReadLine();
                Console.WriteLine("Please enter your password here : ");
                enteredPassword = Console.ReadLine();
                if (enteredUsername == existingUser && enteredPassword == existingPassword)
                {
                    Console.WriteLine("Hi " + enteredUsername + "!\nWelcome back.\nWe currently offer no services. Goodbye.");
                }
            } else
            {
                Console.WriteLine("Apologies but we were unable to understand your answer.")
            }
            Console.Read();
        }
    }
}

