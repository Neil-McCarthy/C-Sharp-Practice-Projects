using System;

namespace Practice_space
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //PROPERTIES

            Box box = new Box();
            box.length = 3;
            box.height = 4;
            box.width = 5;

            box.DisplayInfo();
            Console.ReadLine();

            
        }
    }
}

