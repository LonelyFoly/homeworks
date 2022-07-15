using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Zoo
{
    public class Animal
    {
        private string name;
        private int number;
        public string Name
        {
            get {return name; }
            set {name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Animal(string name_, int number_)
        {
            Name = name_;
            Number = number_;
        }

        public string Talk()
        {
            return "Приветик! Меня зовут "+Name+".";
        }

        public virtual string Type()
        {
            return "Я нинаю, кто я";
        }
        

    }
}
