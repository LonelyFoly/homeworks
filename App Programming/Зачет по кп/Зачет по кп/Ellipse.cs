using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачет_по_кп
{
    public class Ellipse : Figure
    {
        public Ellipse(float ax, float ay, float aw, float ah, Color c) :
            base(ax, ay, aw, ah, c)
        { }
        public override void Draw(Graphics g)
        {
            //pen = new Pen(color);
            g.DrawEllipse(pen, x, y, w, h);
            g.FillEllipse(brush, x, y, w, h);
        }
        public override void Fill(Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x + 1, y + 1, w - 2, h - 2);
        }
        public override bool Touch(float ax, float ay)
        {
            float ww, hh;
            ww = w / 2;
            hh = h / 2;
            return ((ax - x - ww) * (ax - x - ww)) / (ww * ww) + ((ay - y - hh) * (ay - y - hh)) / (hh * hh) <= 1;
        }
        public override void ChangePen(Color clr, int size)
        {
            pen = new Pen(clr, size);
        }
    }
}
