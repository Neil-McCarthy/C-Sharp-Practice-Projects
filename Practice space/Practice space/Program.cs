using System;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //LOOPS
            
            //FOR LOOPS
            for (int index0 = -3; index0 < 4; index0++)
            {
                Console.WriteLine(index0);
            }
            Console.WriteLine("");

            //DO LOOPS
            int index1 = 0;
            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index1 < 10);
            Console.WriteLine("");

            //WHILE LOOPS
            int index2 = 3;
            while (index2 > -4)
            {
                Console.WriteLine(index2);
                index2--;
            }
            Console.ReadLine();
        }
    }
}

