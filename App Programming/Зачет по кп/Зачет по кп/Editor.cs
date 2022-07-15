using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачет_по_кп
{
    public partial class Editor : Form
    {
        public Form1 m_parent;
        public Figure figure;
        public Figure orig;
        public decimal stop1, stop2;

        public Editor(Form1 frm1)
        {
            InitializeComponent();
            m_parent = frm1;

        }

        private void Editor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //numericUpDown1.Value = (decimal)figure.w;
            //numericUpDown2.Value = (decimal)figure.h;
            figure.x = Width / 2 - figure.w / 2;
            figure.y = Height / 2 - figure.h / 2 - 50;
            if (figure is Tractor && (float)numericUpDown1.Value > (float)numericUpDown2.Value / 2)
            {
                figure.Move(Width / 2 - figure.w / 2, Height / 2 - figure.h / 8 - 50);
            }
            figure.Draw(e.Graphics);
            //Refresh();
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (orig.enabled)
            {
                if (figure is Tractor && (float)numericUpDown1.Value > (float)numericUpDown2.Value / 2)
                {
                    orig.w = (float)numericUpDown1.Value;
                    figure.w = (float)numericUpDown1.Value;
                    orig.reCreate();
                    figure.reCreate();
                    stop1 = numericUpDown1.Value;
                    
                }
                else
                {
                    orig.w = (float)numericUpDown1.Value;
                    figure.w = (float)numericUpDown1.Value;
                }
            }
            if (figure is Tractor && (float)numericUpDown1.Value <= (float)numericUpDown2.Value / 2)
            {
                numericUpDown1.Value = stop1;
            }
            Refresh();
            m_parent.Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (orig.enabled)
            {
                if (figure is Tractor && (float)numericUpDown1.Value > (float)numericUpDown2.Value / 2)
                {
                    orig.h = (float)numericUpDown2.Value;
                    figure.h = (float)numericUpDown2.Value;
                    orig.reCreate();
                    figure.reCreate();
                    stop2 = numericUpDown2.Value;
                    
                    //figure.x = Width / 2 - figure.w / 2;
                    //figure.y = Height / 2 - figure.h / 2 - 50;
                }
                else
                {
                    orig.h = (float)numericUpDown2.Value;
                    figure.h = (float)numericUpDown2.Value;
                }              
            }
            if (figure is Tractor && (float)numericUpDown1.Value <= (float)numericUpDown2.Value / 2)
            {
                numericUpDown2.Value = stop2;
            }
            Refresh();
            m_parent.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (orig.enabled)
                {
                    orig.color = cd.Color;
                    figure.color = cd.Color;
                    orig.brush = new SolidBrush(cd.Color);
                    figure.brush = new SolidBrush(cd.Color);
                    orig.pen = new Pen(new SolidBrush(cd.Color));
                    figure.pen = new Pen(new SolidBrush(cd.Color));
                    if (orig is Tractor)
                    {
                        orig.ChangeColor(cd.Color);
                        figure.ChangeColor(cd.Color);
                    }
                }
            }
            Refresh();
            m_parent.Refresh();
        }

        private void Editor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (figure is Tractor && orig.enabled == true)
                {
                    Tractor trac = (Tractor)figure;
                    Tractor trac2 = (Tractor)orig;
                    if (trac.rec1.Touch(e.X, e.Y))
                    {
                        ColorDialog cd = new ColorDialog();
                        if (cd.ShowDialog() == DialogResult.OK)
                        {
                            trac.rec1.color = cd.Color;
                            trac.rec1.brush = new SolidBrush(cd.Color);
                            trac.rec1.pen = new Pen(cd.Color);
                            trac2.rec1.color = cd.Color;
                            trac2.rec1.brush = new SolidBrush(cd.Color);
                            trac2.rec1.pen = new Pen(cd.Color);
                        }
                    }
                    if (trac.rec2.Touch(e.X, e.Y))
                    {
                        ColorDialog cd = new ColorDialog();
                        if (cd.ShowDialog() == DialogResult.OK)
                        {
                            trac.rec2.color = cd.Color;
                            trac.rec2.brush = new SolidBrush(cd.Color);
                            trac.rec2.pen = new Pen(cd.Color);
                            trac2.rec2.color = cd.Color;
                            trac2.rec2.brush = new SolidBrush(cd.Color);
                            trac2.rec2.pen = new Pen(cd.Color);
                        }
                    }
                    if (trac.ell1.Touch(e.X, e.Y))
                    {
                        ColorDialog cd = new ColorDialog();
                        if (cd.ShowDialog() == DialogResult.OK)
                        {
                            trac.ell1.color = cd.Color;
                            trac.ell1.brush = new SolidBrush(cd.Color);
                            trac.ell1.pen = new Pen(cd.Color);
                            trac2.ell1.color = cd.Color;
                            trac2.ell1.brush = new SolidBrush(cd.Color);
                            trac2.ell1.pen = new Pen(cd.Color);
                        }
                    }
                    if (trac.ell2.Touch(e.X, e.Y))
                    {
                        ColorDialog cd = new ColorDialog();
                        if (cd.ShowDialog() == DialogResult.OK)
                        {
                            trac.ell2.color = cd.Color;
                            trac.ell2.brush = new SolidBrush(cd.Color);
                            trac.ell2.pen = new Pen(cd.Color);
                            trac2.ell2.color = cd.Color;
                            trac2.ell2.brush = new SolidBrush(cd.Color);
                            trac2.ell2.pen = new Pen(cd.Color);
                        }
                    }
                }
            }
            Refresh();
            m_parent.Refresh();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void Editor_Activated(object sender, EventArgs e)
        {
            
        }

        private void Editor_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
