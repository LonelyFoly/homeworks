using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Zoo
{
    class Cat: Animal, IWalk
    {
        public Cat(string name_, int number_) : base(name_, number_) { }
        public string Walk()
        {
            return "Я умею ходить!";
        }
        public override string Type()
        {
            return "Кис-кис, кис-кис. Я котик - ты котик.";
        }
    }
}
