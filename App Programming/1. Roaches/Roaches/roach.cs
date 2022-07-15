using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roaches
{
    class roach
    {
        public int x, y;
        int speed;
        public roach(int y_, int speed_)
        {

            y = y_;
            speed = speed_;

        }

        public void move ()
        {
            x += speed;
        }

        public void Draw (Graphics g)
        {
            
            Bitmap body = new Bitmap(Properties.Resources.roach);
            Bitmap body2 = new Bitmap(body, new Size(160,120));
            
            g.DrawImage(body2, x, y);
            //g.DrawEllipse(new Pen(Color.Black), x, y, 25, 25);
        }
    }
}
