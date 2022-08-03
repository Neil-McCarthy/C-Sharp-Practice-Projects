using System;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //LOOPS
            
            //FOR LOOPS
            for (int index0 = 1; index0 < 20; index0+=2)
            {
                Console.WriteLine(index0);
            }

            //DO LOOPS
            int index1 = 0;
            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index1 < 10);

            //WHILE LOOPS
            int index2 = 0;
            while (index2 < 10)
            {
                Console.WriteLine(index2);
                index2++;
            }
            Console.ReadLine();
        }
    }
}

