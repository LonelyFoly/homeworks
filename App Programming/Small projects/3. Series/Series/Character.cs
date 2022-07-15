using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Series
{
    class Character
    {
        private string name;
        private int number;
        private int portret;
        private string town;
        private string hobby;
        private string birthday;
        //private string temperament;
        public string Name
        {
            get {
                return name;
                }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Portret
        {
            get { return portret; }
            set { portret = value; }
        }
        public string Town
        {
            get
            {
                return town;
            }
            set { town = value; }
        }
        public string Hobby
        {
            get
            {
                return hobby;
            }
            set { hobby = value; }
        }
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set { birthday= value; }
        }
        /*public string Temperament
        {
            get
            {
                return temperament;
            }
            set { temperament = value; }
        }*/
    }
}
