using System;

namespace Practice_space
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //ARRAYS
            int[] grades = new int[5];
            grades[0] = 5;
            grades[1] = 4;
            grades[2] = 3;
            grades[3] = 2;
            grades[4] = 1;
            for (int index = 0;index < grades.Length; index++)
            {
                Console.WriteLine(grades[index]);
            }

            Console.ReadLine();

            
        }
    }
}

