using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_space
{
    class Box
    {
        //member variables
        public int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} and volume is {3}", length, height, width, volume = length * height * width);
        }






    } 
}
