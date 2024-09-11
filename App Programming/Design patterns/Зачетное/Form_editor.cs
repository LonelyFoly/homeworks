using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачетное
{
    //
    public partial class Form_editor : Form
    {
        Form1 form;
        int x, y;
        public Form_editor(Form1 form_input)
        {
            InitializeComponent();
            form = form_input;
            
            //this.Location = coords_input;
        }

        private void Form_editor_Load(object sender, EventArgs e)
        {
            this.Location = form.coords;
            if (!(thing is null))
            {
                oldValue_w = thing.w;
                oldValue_h = thing.h;
                numericUpDown1.Value = (decimal)thing.w;
                numericUpDown2.Value = (decimal)thing.h;
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        { if (thing.active)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {

                    Color color = colorDialog1.Color;
                    drawing_thing.color = color;
                    if (thing is Tracks)
                    {
                        Tracks tr = (Tracks)drawing_thing;
                        tr.c_big.color = color;
                        tr.c_small.color = color;
                        tr.wheel_left.color = color;
                        tr.wheel_right.color = color;
                    }
                    button1.BackColor = color;
                }
                
                Refresh();
            }
        }
        public Things thing;
        Things drawing_thing;
        public void ChangeThing(Things thing_input)
        {
            if (thing_input is Tracks)
                numericUpDown2.Maximum = 120;
            else
                numericUpDown2.Maximum = 250;

            thing = thing_input;
            button1.BackColor = thing.color;
            if (thing is Rect)
            {
                drawing_thing = new Rect(Width / 2 - thing.w / 2, (Height - 120) / 2 - thing.h / 2, thing.w, thing.h, thing.color);
            }
            else if (thing is Elips)
            {
                drawing_thing = new Elips(Width / 2 - thing.w / 2, (Height - 120) / 2 - thing.h / 2, thing.w, thing.h, thing.color);
            }
            else
            {
                drawing_thing = new Tracks(Width / 2 - thing.w / 2, (Height - 120) / 2 - thing.h / 2, thing.w, thing.h, thing.color);
                Tracks tr = (Tracks)drawing_thing;
                Tracks tr2= (Tracks)thing;
                tr.c_big.color = tr2.c_big.color;
                tr.c_small.color = tr2.c_small.color;
                tr.wheel_left.color = tr2.wheel_left.color;
                tr.wheel_right.color = tr2.wheel_right.color;

            }
            numericUpDown1.Value = (decimal)thing.w;
            numericUpDown2.Value = (decimal)thing.h;
            Refresh();

        }

        private void Form_editor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            drawing_thing.editor_change();
            drawing_thing.x0 = Width / 2 - drawing_thing.w / 2;
            drawing_thing.y0 = (Height - 120) / 2 - drawing_thing.h / 2;

            thing.w = drawing_thing.w;
            thing.h = drawing_thing.h;

            thing.color = drawing_thing.color;
            if (thing is Tracks)
            {

                Tracks tr = (Tracks)thing;
                Tracks tr_draw = (Tracks)drawing_thing;
                tr.c_big.color = tr_draw.c_big.color;
                tr.c_small.color = tr_draw.c_small.color;
                tr.wheel_left.color = tr_draw.wheel_left.color;
                tr.wheel_right.color = tr_draw.wheel_right.color;
                
            }

            e.Graphics.Clear(Color.White);
            if (thing.active)
                drawing_thing.SelectedDraw(e.Graphics);
            else
                drawing_thing.Draw(e.Graphics);

            thing.editor_change();
            form.Refresh();
            
        }

        private void Form_editor_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (thing is Tracks)&&(thing.active))
            {
                Tracks tr = (Tracks)drawing_thing;
                Tracks tr_true = (Tracks)thing;

                if (tr.wheel_left.Touch(e.X, e.Y))
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {

                        tr.wheel_left.color = colorDialog1.Color;

                    }
                    
                        
                }
                if (tr.wheel_right.Touch(e.X, e.Y))
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {

                        tr.wheel_right.color = colorDialog1.Color;

                    }


                }
                if (tr.c_small.Touch(e.X, e.Y))
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {

                        tr.c_small.color = colorDialog1.Color;

                    }


                }
                if (tr.c_big.Touch(e.X, e.Y))
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {

                        tr.c_big.color = colorDialog1.Color;
                        tr.color = colorDialog1.Color;

                    }


                }



            }
            Refresh();
        }
        public int oldValue_w;
        public int oldValue_h;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (((numericUpDown1.Value < numericUpDown2.Value)&&(thing is Tracks)) || (!thing.active))
            {
                numericUpDown1.Value = oldValue_w;
            }
            else
            {
                drawing_thing.w = (int)numericUpDown1.Value;
                oldValue_w = (int)numericUpDown1.Value;
                Refresh();
                
            }
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (((numericUpDown1.Value < numericUpDown2.Value) && (thing is Tracks)) || (!thing.active))
            {
                numericUpDown2.Value = oldValue_h;
            }
            else
            {
                drawing_thing.h = (int)numericUpDown2.Value;
                oldValue_h = (int)numericUpDown2.Value;
                Refresh();
            }
        }

        private void Form_editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.editor_openned = false;
            form.coords= this.Location;
        }
    }
}
