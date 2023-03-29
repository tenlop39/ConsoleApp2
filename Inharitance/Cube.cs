using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
    class Cube : Shape, IShape //ctrl + dot => implement interface
    {
        
        public Cube(int width, int height, int length) // construktor. stejny nzev jako classa
        {
            Width = width;
            Height = height;
            Length = length;

        }

        public double Width { get; set; }        

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetVolume()
        {
            return Length * Width * Height;
        }

    }
}
