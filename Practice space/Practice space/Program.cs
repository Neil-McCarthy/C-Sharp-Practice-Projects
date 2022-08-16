using System;

namespace Practice_space
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //MULTI DIMENSIONAL ARRAYS

            //TWO DIMENSIONAL 
            int[,] arrays2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            //THREE DIMENSIONAL
            int[,,] arrays3D = new int[,,]
            {
                {
                    {000, 001},
                    {010, 011}
                },
                {
                    {100, 101},
                    {110, 111}
                }
            };


            //NESTED FOR LOOPS METHOD - PRINT ONLY EVEN NUMBERS
            for (int index = 0; index < arrays2D.GetLength(0); index++)
            {
                for (int blindex = 0; blindex < arrays2D.GetLength(1); blindex++)
                {
                    if (arrays2D[index, blindex] % 2 == 0)
                    {
                        Console.WriteLine(arrays2D[index, blindex]);
                    }
                }
            }
            /*foreach (int index in arrays2D)
            {
                Console.Write(index + " ");
            }*/

            Console.ReadLine();

            
        }
    }
}

