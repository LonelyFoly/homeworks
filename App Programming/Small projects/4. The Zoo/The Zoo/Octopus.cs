using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Zoo
{
    class Octopus: Animal, ISwim
    {
        public Octopus(string name_, int number_) : base(name_, number_) { }
        public string Swim()
        {
            return "Я умею плавать!";
        }
        public override string Type()
        {
            return "Я осьминожка";
        }
    }
}
