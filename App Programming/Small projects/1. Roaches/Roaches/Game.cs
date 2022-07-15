using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roaches
{
    class Game
    {
        public List <roach> Roaches = new List<roach>();
        public List<int> Winners = new List<int>();
        public void Draw (Graphics g)
        {
            g.DrawLine(new Pen(Color.Black), 50, 50, 500, 50);
            g.DrawLine(new Pen(Color.Black), 50, 130, 500, 130);
            g.DrawLine(new Pen(Color.Black), 50, 210, 500, 210);
            g.DrawLine(new Pen(Color.Black), 50, 290, 500, 290);
            g.DrawLine(new Pen(Color.Black), 50, 370, 500, 370);
            g.DrawLine(new Pen(Color.Black), 50, 450, 500, 450);
            g.FillRectangle(new SolidBrush(Color.Black), 500, 50, 50, 400);
            foreach (var item in Roaches)
            {
                item.Draw(g);
            }
        }
        Random rnd = new Random();
        public void Create()
        {
            if (Roaches.Count!=0)
            {
                Roaches.Add(new roach(Roaches[Roaches.Count - 1].y + 80, rnd.Next(1, 50)));
            }
            else
                Roaches.Add(new roach(20, rnd.Next(1, 50)));

        }
        public void Remove()
        {
            Roaches.RemoveAt(Roaches.Count - 1);
        }
        public void Reload()
        {
            for (int i = 0; i < Roaches.Count; i++)
            {
                Roaches[i] = new roach(Roaches[i].y, rnd.Next(1, 50));
            }
        }
        public void Action ()
        {
            foreach (var item in Roaches)
            {
                item.move();

            }

            for (int i = 0; i < Roaches.Count; i++)
            {
                if(Roaches[i].x >= 500-110)
                {
                    Winners.Add(i+1);
                    
                }
            }
        }
        public void ToDefault ()
        {
           
            for (int i = 0; i < Roaches.Count; i++)
            {
                Roaches[i].x =0;
            }
            Winners = new List<int>();
        }
        public bool Check ()
        {
            if (Winners.Count!=0)
            {

                return true;
            }
            return false;
        }
        public bool WIN(int n)
        {
            foreach (var item in Winners)
            {
                if (n == item)
                    return true;
            }
            return false;
        }
        
    }
}
