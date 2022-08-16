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

            Console.WriteLine("7 value is {0}", arrays2D[2, 0]);

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

            Console.WriteLine("100 is {0}", arrays3D[1, 0, 0]);

            //CHECK NUMBER OF DIMENSIONS
            int dimensions = arrays2D.Rank;
            Console.WriteLine(dimensions);
            dimensions = arrays3D.Rank;
            Console.WriteLine(dimensions);


            //WRITE ARRAYS FASTER
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(array2D2[0, 1]);

            Console.ReadLine();

            
        }
    }
}

