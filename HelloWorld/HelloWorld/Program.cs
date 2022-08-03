using System;

namespace HelloWorld
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int value = 5;
            string oddOrEven;
            if (value % 2 == 0)
            {
                oddOrEven = "even number";
            }
            else
            {
                oddOrEven = "odd number";
            }
            if (value % 3 == 0 && value % 7 == 0)
            {
                Console.WriteLine("value is divisinle by both 3 and 7 and number is " + oddOrEven);
            }
            else if (value % 3 == 0)
            {
                Console.WriteLine("value is divisinle by 3 and number is " + oddOrEven);
            }
            else if (value % 7 == 0)
            {
                Console.WriteLine("value is divisinle by 7 and number is " + oddOrEven);
            }
            else
            {
                Console.WriteLine("final test");
            }
            Console.Write("Please enter the temperature : ");
            string temperatureInput = Console.ReadLine();
            int temperature;
            //bool success = int.TryParse(temperatureInput, out temperature);
            if (int.TryParse(temperatureInput, out temperature))
            {
                if (temperature < 10 && temperature > 0)
                {
                    Console.WriteLine("When it's coooold outside");
                }
                else if (temperature > 10 && temperature < 20)
                {
                    Console.WriteLine("Hot as balls");
                }
                else if (temperature == 10)
                {
                    Console.WriteLine("10 is the bla bla bla bla");
                }
                else
                {
                    Console.WriteLine("Too hot or too cold");
                }
            }
            else
            {
                Console.WriteLine("Sorry but the value you entered cannot be recognised " + temperature);
            }
            Console.Read();
        }
    }
}

