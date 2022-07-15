using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Faces
{
    class Eye
    {
        Pupil pupil;
        double x;
        double y;
        double centerX;
        double centerY;
        double radius;
        double angle;
        double size;
        double koef;

        public Eye(double ax, double ay, double asize)
        {
            x = ax;
            y = ay;
            centerX = ax + asize / 2;
            centerY = ay + asize / 2;
            size = asize;
            pupil = new Pupil(centerX, centerY, 10);
        }

        public void Update(double mx, double my)
        {
            if (my < centerY)
            {
                koef = -1;
            }
            else
            {
                koef = 1;
            }
            radius = Math.Sqrt((mx - centerX) * (mx - centerX) + (my - centerY) * (my - centerY));
            angle = koef*Math.Acos((mx - centerX)/ radius);

            double bx = radius*0.1;
           

            pupil.X = bx * Math.Cos(angle) + centerX;
            pupil.Y = bx * Math.Sin(angle) + centerY;

        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, (float)x, (float)y, (float)size, (float)size);
            pupil.Draw(g);
        }
    }
}
