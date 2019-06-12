using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        private int length;
        private int height;
        //private int width;
        private int volume;

        // auto implemented property (type "prop" hit tab tab)
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
                    value = -value;
                //throw new Exception("Size needs to be positive.");
                height = value;
            }
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        public void DisplayInfo()
        {
            Console.Write("Length is {0}, Height is {1}, Width is {2}, and so the volume is {3}!", length, height, Width, volume = length * Width * height);
        }
    }
}
