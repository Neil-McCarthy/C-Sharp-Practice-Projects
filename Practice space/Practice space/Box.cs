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
        private int length;
        private int height;
        private int width;
        public int volume;

        /*public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }*/

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }


        /*public void SetLength(int length)
        {
            this.length = length;
        }*/

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} and volume is {3}", length, height, width, volume = length * height * width);
        }






    } 
}
