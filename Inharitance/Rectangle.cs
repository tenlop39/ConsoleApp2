using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
    class Rectangle : Shape, IShape //ctrl + dot => implement interface
    {
        public double Width { get; set; }

        

        public double GetArea()
        {
            return Length * Width;
        }
    }
}
