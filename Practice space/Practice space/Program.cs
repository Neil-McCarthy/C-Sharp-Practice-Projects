using System;

namespace Practice_space
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //ARRAYS
            int[] grades = { 1, 2, 3, 4, 5 };
            /*grades[0] = 5;
            grades[1] = 4;
            grades[2] = 3;
            grades[3] = 2;
            grades[4] = 1;*/

            string[] names = { "Bingus", "Flingus", "and", "Mo" };
            
            for (int index = 0;index < grades.Length; index++)
            {
                Console.WriteLine(grades[index]);
            }
            Console.WriteLine("");
            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }

            Console.ReadLine();

            
        }
    }
}

