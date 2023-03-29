using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_nad_objects_OOP
{
    internal static class StaticClass
    {
        public static int rokNarozeniStatic(int age)
        {
            int rok = DateTime.Now.Year - age;
            return rok;
        }
    }
}
