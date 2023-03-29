using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
    class Triangle : Shape, IShape //ctrl + dot => implement interface
    {
        public Triangle() 
        { 
        }

        public Triangle(int hyp)
        {
            
        }
        

        public double Hypotenuese { get; set; }//prepona       
        public double GetArea()
        {
            return .5 * Length * Height;
        }
    }
}
