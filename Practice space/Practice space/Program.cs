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

            //FOREACH LOOPS WITH MULTI DIMENSIONS
            foreach (int index in arrays2D)
            {
                Console.Write(index + " ");
            }

            foreach (int index in arrays3D)
            {
                Console.Write(index + " ");
            }

            //NESTED FOR LOOPS METHOD
            for (int index = 0; index < arrays2D.GetLength(0); index++)
            {
                for (int blindex = 0; blindex < arrays2D.GetLength(1); blindex++)
                {
                    arrays2D[index, blindex] = index + blindex;
                }
            }
            foreach (int index in arrays2D)
            {
                Console.Write(index + " ");
            }

            Console.ReadLine();

            
        }
    }
}

