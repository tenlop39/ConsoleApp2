using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_nad_objects_OOP
{
    //internal znamez, ze k teto classe je povolen pristup pouze ze slozky classs and objects oop
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Field
        private int _plat { get; set; }
        private string _tajemstvi { get; set; }



        //zapouzdreni pro plat
        public void setPlat(int plat)
        {
            _plat = plat;
        }

        public double getPlat()
        {
            return _plat;
        }

        //---------------------------------------

        //metoda ktera vypise cele jmeno
        public string fullName()
        {
            return $"{FirstName} {LastName}";
        }
        //overload stejna metoda, ale ma parametr
        public string fullName(string prostredniJmeno)
        {
            return $"{FirstName} {prostredniJmeno} {LastName}";
        }

        //---------------------------------------

        //metoda ktera vezme aktualni rok a odecte od nej vek => rok narozeni
        public int rokNarozeni()
        {
            int rok = DateTime.Now.Year - Age;
            return rok;
        }

        //----------------------------------------

        //test zapouzdreni
        public void setTajemstvi(string tajemstvi)
        {
            _tajemstvi = tajemstvi;
        }
        public string getTajemstvi()
        {
            return _tajemstvi;
        }

    }
}
