using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачет_по_кп
{
    public class Tractor : Figure
    {
        public Rect rec1, rec2;
        public Ellipse ell1, ell2;
        public Tractor(float ax, float ay, float aw, float ah, Color c) :
            base(ax, ay, aw, ah, c)
        {
            rec1 = new Rect(x, y, w, h / 4, c);
            rec2 = new Rect(x, y - h / 4 - 1, w / 3, h / 4, c);
            ell1 = new Ellipse(x, y + h / 4 + 1, h / 4, h / 4, c);
            ell2 = new Ellipse(x + w - h / 4, y + h / 4 + 1, h / 4, h / 4, c);
        }
        public override void Draw(Graphics g)
        {
            //rec1.pen = pen;
            //rec2.pen = pen;
            //ell1.pen = pen;
            //ell2.pen = pen;
            rec1.Draw(g);
            rec2.Draw(g);
            ell1.Draw(g);
            ell2.Draw(g);
        }
        public override bool Touch(float ax, float ay)
        {
            return rec1.Touch(ax, ay) || rec2.Touch(ax, ay) || ell1.Touch(ax, ay) || ell2.Touch(ax, ay);
        }
        public override void ChangeEnable()
        {
            if (enabled)
            {
                enabled = false;
                pen = new Pen(color, 1);
                rec1.brush = new SolidBrush(Color.FromArgb(150, color));
                rec2.brush = new SolidBrush(Color.FromArgb(150, color));
                ell1.brush = new SolidBrush(Color.FromArgb(150, color));
                ell2.brush = new SolidBrush(Color.FromArgb(150, color));
                rec1.pen = new Pen(rec1.brush);
                rec2.pen = new Pen(rec2.brush);
                ell1.pen = new Pen(ell1.brush);
                ell2.pen = new Pen(ell2.brush);
            }
            else
            {
                enabled = true;
                rec1.brush = new SolidBrush(color);
                rec2.brush = new SolidBrush(color);
                ell1.brush = new SolidBrush(color);
                ell2.brush = new SolidBrush(color);
                rec1.pen = new Pen(brush);
                rec2.pen = new Pen(brush);
                ell1.pen = new Pen(brush);
                ell2.pen = new Pen(brush);
            }
        }
        public override void Move(float ax, float ay)
        {
            x = ax;
            y = ay;
            rec1.x = ax;
            rec1.y = ay;
            rec2.x = ax;
            rec2.y = ay - h / 4 - 1;
            ell1.x = ax;
            ell1.y = ay + h / 4 + 1;
            ell2.x = ax + w - h /4;
            ell2.y = ay + h / 4 + 1;
        }
        public override void ChangeColor(Color clr)
        {
            rec1.brush = new SolidBrush(clr);
            rec2.brush = new SolidBrush(clr);
            ell1.brush = new SolidBrush(clr);
            ell2.brush = new SolidBrush(clr);
        }
        public override void reCreate()
        {
            rec1 = new Rect(x, y, w, h / 4, rec1.color);
            rec2 = new Rect(x, y - h / 4 - 1, w / 3, h / 4, rec2.color);
            ell1 = new Ellipse(x, y + h / 4 + 1, h / 4, h / 4, ell1.color);
            ell2 = new Ellipse(x + w - h / 4, y + h / 4 + 1, h / 4, h / 4, ell2.color);
        }
    }
}
