using System;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //ENHANCED IF EXERCISE
            Console.Write("Please enter a temperature : ");
            string userInput = Console.ReadLine();
            int convertedValue;
            if (int.TryParse(userInput, out convertedValue))
            {
                string result = convertedValue <= 15? "it is too cold here" : convertedValue <= 28 ? "it is ok" : convertedValue > 28 ? "it is hot here" : "";
                Console.WriteLine(result);
            }

            
            Console.ReadLine();
        }
    }
}

