using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачетное
{
    public class Elips :Things
    {
        /*public Elips(int x0_input, int y0_input, int w_input, int h_input, Color color_input) :
            base(x0_input, y0_input, w_input, h_input, color_input)
        { }*/
        public Elips(int x0_input, int y0_input, int w_input, int h_input, Color color_input)
        {
            x0 = x0_input;
            y0 = y0_input;
            w = w_input;
            h = h_input;
            color = color_input;
            active = true;

        }
        public override IPrototype clone()
        {
            return new Elips(x0, y0, w, h, color);
        }
        public override IMemento Save()
        {
            string save_line = "Elips ";
            save_line += Convert.ToString(x0) + " " + Convert.ToString(y0) +
                " " + Convert.ToString(w) + " " + Convert.ToString(h) + " " +
                color.ToArgb().ToString() + " " + Convert.ToString(active) + " ";
            return new SaveMemento(save_line);
        }
        public override void Load(IMemento input)
        {

            string info = input.GetState();
            string[] temp = new string[11];
            temp = info.Split(Convert.ToChar(" "));
            x0 = Convert.ToInt32(temp[1]);
            y0 = Convert.ToInt32(temp[2]);
            w = Convert.ToInt32(temp[3]);
            h = Convert.ToInt32(temp[4]);
            color = Color.FromArgb(Convert.ToInt32(temp[5]));
            if (temp[6] == "False")
                Change();

        }
        public override void Draw(Graphics g)
        {
            //переменная обратного цвета

            
            g.DrawEllipse(new Pen(color), x0, y0, w, h);

            SolidBrush brush = new SolidBrush(color);
            
            g.FillEllipse(brush, x0, y0, w, h);
            
            //g.FillEllipse(brush, x0 + 1, y0 + 1, w - 1, h - 1);

        }
        public override void SelectedDraw(Graphics g)
        {
            Color color_inv = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            g.DrawEllipse(new Pen(color_inv,5), x0, y0, w, h);
            SolidBrush brush_inv = new SolidBrush(color);
            g.FillEllipse(brush_inv, x0, y0, w, h );
        }

        public override bool Touch(float mx, float my)
        {
            float ww, hh;
            ww = w / 2;
            hh = h / 2;
            return ((mx - x0 - ww) * (mx - x0 - ww)) / (ww * ww) + ((my - y0 - hh) * (my - y0 - hh)) / (hh * hh) <= 1;
        }
        public override void Move(int x, int y, int rx, int ry)
        {
            x0 = x - rx;
            y0 = y - ry;
        }

    }
}
