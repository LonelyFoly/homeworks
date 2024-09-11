using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Зачетное
{
    class Tracks : Things
    {
        public Rect c_big, c_small;
        public Elips wheel_left, wheel_right;
            int  h_small, w_small, w_wheel;
        public override IPrototype clone()
        {
            return new Tracks(x0, y0, w, h, color);
        }
        public override IMemento Save()
        {

            string save_line = "Tracks ";
            save_line += Convert.ToString(x0) + " " + Convert.ToString(y0) +
                " " + Convert.ToString(w) + " " + Convert.ToString(h) + " " +
                color.ToArgb().ToString() + " " + Convert.ToString(active) + " ";
            save_line += c_big.color.ToArgb().ToString() +
                " " + c_small.color.ToArgb().ToString() + " " + 
                wheel_left.color.ToArgb().ToString() + " " + wheel_right.color.ToArgb().ToString();
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


            c_big = new Rect(x0, y0, w, h, color);
            w_small = w / 4;
            h_small = h / 2;
            c_small = new Rect(x0, y0 - h_small, w_small, h_small, color);


            w_wheel = h / 2;
            wheel_left = new Elips(x0 - w_wheel, y0 + h - w_wheel, w_wheel * 2, w_wheel * 2, color);
            wheel_right = new Elips(x0 + w - w_wheel, y0 + h, w_wheel, w_wheel, color);

        }
        public Tracks(int x0_input, int y0_input, int w_input, int h_input, Color color_input)
        {
            x0 = x0_input;
            y0 = y0_input;
            active = true;
            color = color_input;
            w = w_input;  
            h = h_input;


            c_big = new Rect(x0,y0,w, h,color);
            w_small = w/4;
            h_small = h / 2;
            c_small = new Rect(x0,y0-h_small,w_small,h_small, color);


            w_wheel = h / 2;
            wheel_left = new Elips(x0-w_wheel,y0+h - w_wheel, w_wheel*2,w_wheel*2, color);
            wheel_right = new Elips(x0+w-w_wheel, y0 + h, w_wheel, w_wheel, color);

        }
        public override void Draw(Graphics g)
        {
            /*Color t = color;//переменная обратного цвета
            g.DrawRectangle(new Pen(color), x0, y0, w, h);
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, x0 + 1, y0 + 1, w - 1, h - 1);*/

            c_big.Draw(g);
            c_small.Draw(g);
            wheel_left.Draw(g);

            wheel_right.Draw(g);
            
            
            
           
        }
        public override void SelectedDraw(Graphics g)
        {

           
            c_big.SelectedDraw(g);

            c_small.SelectedDraw(g);
            wheel_left.SelectedDraw(g);

            wheel_right.SelectedDraw(g);
        }
        public override bool Touch(float mx, float my)
        {
            return (wheel_left.Touch(mx, my) || wheel_right.Touch(mx, my) || c_big.Touch(mx, my) || c_small.Touch(mx, my));
        }
        public override void Move(int x, int y, int rx, int ry)
        {
            x0 = x - rx;
            y0 = y - ry;
            c_big.x0 = x0;
            c_big.y0 = y0;
            c_small.x0 = x0;
            c_small.y0 = y0 - h_small;
            wheel_left.x0 = x0-w_wheel;
            wheel_left.y0 = y0 + h-w_wheel;
            wheel_right.x0 = x0 + w - w_wheel;//
            wheel_right.y0 = y0 + h;

        }
        public override void Change()
        {

            if (active)
            {
                color = Color.FromArgb(100, color);
                c_big.color = Color.FromArgb(100, c_big.color);
                c_small.color = Color.FromArgb(100, c_small.color);
                wheel_left.color = Color.FromArgb(100, wheel_left.color);
                wheel_right.color = Color.FromArgb(100, wheel_right.color);
            }
            else
            {
                c_big.color = Color.FromArgb(255, c_big.color);
                c_small.color = Color.FromArgb(255, c_small.color);
                wheel_left.color = Color.FromArgb(255, wheel_left.color);
                wheel_right.color = Color.FromArgb(255, wheel_right.color);
            }
                
            active = !active;


        }
        public override void editor_change ()
        {
            c_big = new Rect(x0, y0, w, h, c_big.color);
            w_small = w / 4;
            h_small = h / 2;
            c_small = new Rect(x0, y0 - h_small, w_small, h_small, c_small.color);


            w_wheel = h / 2;
            wheel_left = new Elips(x0 - w_wheel, y0 + h - w_wheel, w_wheel * 2, w_wheel * 2, wheel_left.color);
            wheel_right = new Elips(x0 + w - w_wheel, y0 + h, w_wheel, w_wheel, wheel_right.color);
        }

    }
}
