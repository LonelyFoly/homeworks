using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Faces
{
    class Face
    {
        Eye eye1;
        Eye eye2;
        double x;
        double y;
        double size;

        public Face (double ax, double ay, double asize)
        {
            x = ax;
            y = ay;
            size = asize;
            eye1 = new Eye(x - size / 2.8, y - size / 3, size / 3);
            eye2 = new Eye(x + size / 20, y - size / 3, size / 3);
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, (float)x - (float)size / 2, (float)y - (float)size / 2, (float)size, (float)size);
            eye1.Draw(g);
            eye2.Draw(g);
        }

        public void Update(double mx, double my)
        {
            eye1.Update(mx, my);
            eye2.Update(mx, my);
        }
    }
}
