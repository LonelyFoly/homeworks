using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Zoo
{
    class Duck: Animal, IWalk, IFly, ISwim
    {
        public Duck(string name_, int number_) : base(name_, number_) { }
        public string Fly()
        {
            return "Я умею летать!";
        }
        public string Swim()
        {
            return "Я умею плавать!";
        }
        public string Walk()
        {
            return "Я умею ходить!";
        }
        public override string Type()
        {
            return "Я уточка";
        }
    }
}
