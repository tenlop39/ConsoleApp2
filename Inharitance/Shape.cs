using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
    abstract internal class Shape //nelze tvorit instance abstraktni klasy, jako static (instantiation) " Shape shape = new Shape();" nelze
    {
        public double Height { get; set; }
        public double Length { get; set; }

        

    }
}


