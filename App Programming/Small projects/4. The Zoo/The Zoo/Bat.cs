using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Zoo
{
    class Bat: Animal, IFly
    {

        public Bat(string name_, int number_) : base(name_, number_) { }
        public string Fly()
        {
            return "Я умею летать!";
        }
        public override string Type()
        {
            return "Я летучая мышь,";
        }
    }
}
