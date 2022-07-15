using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачет_по_кп
{
    public class Rect : Figure
    {
        public Rect(float ax, float ay, float aw, float ah, Color c) :
           base(ax, ay, aw, ah, c)
        { }
        public override void Draw(Graphics g)
        {
            
            g.DrawRectangle(pen, x, y, w, h);
            g.FillRectangle(brush, x, y, w, h);
        }
        public override void Fill(Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, x + 1, y + 1, w - 1, h - 1);
        }
        public override bool Touch(float ax, float ay)
        {
            return ax >= x && ax <= x + w && ay >= y && ay <= y + h;
        }
        public override void ChangePen(Color clr, int size)
        {
            //clr = Color.FromArgb(255 - clr.R, 255 - clr.G, 255 - clr.B);
            pen = new Pen(clr, size);
        }
    }
}
