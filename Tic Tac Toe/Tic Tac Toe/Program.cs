using System;

namespace Practice_space
{
    class Program
    {
        static void Main(string[] args)
        {

            //JAGGED ARRAYS - ARRAYS WITHIN ARRAYS

            //FIRST OPTION
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //SECOND OPTION
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            //EXERCISE - PRINT ALL OPTIONS FROM OPTION 2
            foreach (int[] index in jaggedArray2)
            {
                foreach (int subIndex in index)
                {
                    Console.WriteLine(subIndex);
                }
                
            }

            Console.ReadLine();
        }
    }
}