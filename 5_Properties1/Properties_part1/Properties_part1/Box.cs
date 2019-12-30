using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_part1
{
    class Box
    {

        private int length;
        private int height;
        //public int width;
        private int volume;

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }

        }

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else {
                    height = value;
                    }
            }

        }

       public void setLenght( int length)
        {
            if (length < 0)
            {
                throw new Exception("Lenght shoudl bne more then 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

       
        public void DisplayInfo()
        {
            Console.WriteLine("Legth is {0} height is {1} and width is {2} volume is {3}", length, height, Width, volume = height * Width * length);
        }

    }
}
