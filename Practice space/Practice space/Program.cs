using System;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //ENHANCED IF STATEMENT
            Console.Write("Please enter a positive or negative number : ");
            string userInput = Console.ReadLine();
            int convertedValue;
            if (int.TryParse(userInput, out convertedValue))
            {
                string result = convertedValue > 0 ? "True" : "False";
                Console.WriteLine(result);
            }

            
            Console.ReadLine();
        }
    }
}

