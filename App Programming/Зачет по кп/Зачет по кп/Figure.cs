using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачет_по_кп
{
    public class Figure
    {
        public float x, y, w, h;
        public Color color;
        public Brush brush;
        public Pen pen;
        public bool enabled = true;

        public Figure(float ax, float ay, float aw, float ah, Color c)
        {
            x = ax;
            y = ay;
            w = aw;
            h = ah;
            color = c;
            brush = new SolidBrush(color);
            pen = new Pen(brush);
        }
        public virtual void Draw(Graphics g) { }
        public virtual void Fill(Graphics g) { }
        public virtual bool Touch(float ax, float ay)
        {
            return false;
        }
        public virtual void ChangeEnable()
        {
            if (enabled)
            {
                enabled = false;
                brush = new SolidBrush(Color.FromArgb(150, color));
                pen = new Pen(brush);
            }
            else
            {
                enabled = true;
                brush = new SolidBrush(color);
                pen = new Pen(brush);
            }
        }
        public virtual void Move(float ax, float ay)
        {
            x = ax;
            y = ay;
        }
        public virtual void ChangeColor(Color clr)
        {

        }
        public virtual void reCreate()
        {

        }
        public virtual void ChangePen(Color clr, int size)
        {

        }
    }
}
