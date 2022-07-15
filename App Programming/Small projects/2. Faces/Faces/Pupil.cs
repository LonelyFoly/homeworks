using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Faces
{
    class Pupil
    {
        double x;
        double y;
        int size;

        public Pupil(double ax, double ay, int asize)
        {
            X = ax;
            Y = ay;
            size = asize;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, (float)x, (float)y, size, size);
            g.FillEllipse(Brushes.Black, (float)x, (float)y, size, size);
        }
    }
}
