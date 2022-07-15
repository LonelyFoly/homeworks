using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Зачет_по_кп
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Editor editor;
        List<Figure> figures = new List<Figure>();
        List<Rect> rects = new List<Rect>();
        List<Ellipse> elipses = new List<Ellipse>();
        List<Tractor> tracs = new List<Tractor>();

        List<Figure> icons = new List<Figure>();
        Figure figure;
        int num1, num2, num3;

        List<CheckBox> chek1 = new List<CheckBox>();
        List<CheckBox> chek2 = new List<CheckBox>();
        List<CheckBox> chek3 = new List<CheckBox>();

        bool makeFig = true;
        bool moving = false;
        float dx, dy;
        Brush br;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            editor = new Editor(this);

            Rect rec = new Rect(7, 26, 8, 8, Color.Black);
            rec.Draw(this.CreateGraphics());
            icons.Add(rec);

            Ellipse ell = new Ellipse(6, 62, 9, 9, Color.Black);
            ell.Draw(this.CreateGraphics());
            icons.Add(ell);

            Tractor trac = new Tractor(6, 102, 11, 11, Color.Black);
            trac.Draw(this.CreateGraphics());
            icons.Add(trac);

            num1 = Convert.ToInt32(numericUpDown1.Value);
            num2 = Convert.ToInt32(numericUpDown2.Value);
            num3 = Convert.ToInt32(numericUpDown3.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (makeFig)
            {
                if (numericUpDown1.Value > num1)
                {
                    Rect r = new Rect(rnd.Next(50, Width - 200), rnd.Next(50, Height - 200), rnd.Next(30, 100), rnd.Next(30, 100), Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));

                    r.Draw(this.CreateGraphics());
                    rects.Add(r);
                    figures.Add(r);

                    CheckBox ch = new CheckBox();
                    ch.Width = 20;
                    ch.Location = new Point(90 + 20 * num1, 20);
                    ch.Checked = true;
                    ch.CheckedChanged += new EventHandler(ch1_Cheked);
                    ch.Tag = num1;
                    Controls.Add(ch);
                    chek1.Add(ch);

                    num1++;
                }
                else
                {
                    for (int i = rects.Count - 1; i >= 0; i--)
                    {
                        rects.RemoveAt(i);
                        Controls.Remove(chek1[i]);
                        chek1.RemoveAt(i);
                        break;
                    }
                    for (int i = figures.Count - 1; i >= 0; i--)
                    {
                        if (figures[i] is Rect)
                        {
                            figures.RemoveAt(i);
                            break;
                        }
                    }
                    num1--;
                }
            }
            
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var fig in figures)
            {
                fig.Draw(e.Graphics);
            }
            foreach (var ic in icons)
            {
                ic.Draw(e.Graphics);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (makeFig)
            {
                if (numericUpDown3.Value > num3)
                {
                    Tractor tr = new Tractor(rnd.Next(50, Width - 200), rnd.Next(50, Height - 200), rnd.Next(50, 100), rnd.Next(30, 100), Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));

                    tr.Draw(this.CreateGraphics());
                    tracs.Add(tr);
                    figures.Add(tr);

                    CheckBox ch = new CheckBox();
                    ch.Width = 20;
                    ch.Location = new Point(90 + 20 * num3, 94);
                    ch.Checked = true;
                    ch.CheckedChanged += new EventHandler(ch3_Cheked);
                    ch.Tag = num3;
                    Controls.Add(ch);
                    chek3.Add(ch);

                    num3++;
                }
                else
                {
                    for (int i = tracs.Count - 1; i >= 0; i--)
                    {
                        tracs.RemoveAt(i);
                        Controls.Remove(chek3[i]);
                        chek3.RemoveAt(i);
                        break;
                    }
                    for (int i = figures.Count - 1; i >= 0; i--)
                    {
                        if (figures[i] is Tractor)
                        {
                            figures.RemoveAt(i);
                            break;
                        }
                    }
                    num3--;
                }
            }
            
            Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (makeFig)
            {
                if (numericUpDown2.Value > num2)
                {
                    Ellipse el = new Ellipse(rnd.Next(50, Width - 200), rnd.Next(50, Height - 200), rnd.Next(30, 100), rnd.Next(30, 100), Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));

                    el.Draw(this.CreateGraphics());
                    elipses.Add(el);
                    figures.Add(el);

                    CheckBox ch = new CheckBox();
                    ch.Width = 20;
                    ch.Location = new Point(90 + 20 * num2, 58);
                    ch.Checked = true;
                    ch.CheckedChanged += new EventHandler(ch2_Cheked);
                    ch.Tag = num2;
                    Controls.Add(ch);
                    chek2.Add(ch);

                    num2++;
                }
                else
                {
                    for (int i = elipses.Count - 1; i >= 0; i--)
                    {
                        elipses.RemoveAt(i);
                        Controls.Remove(chek2[i]);
                        chek2.RemoveAt(i);
                        break;
                    }
                    for (int i = figures.Count - 1; i >= 0; i--)
                    {
                        if (figures[i] is Ellipse)
                        {
                            figures.RemoveAt(i);
                            break;
                        }
                    }
                    num2--;
                }
            }
            
            Refresh();
        }
        private void ch1_Cheked(object sender, EventArgs e)
        {
            CheckBox chek = (CheckBox)sender;
            rects[(int)chek.Tag].ChangeEnable();
            rects[(int)chek.Tag].Draw(this.CreateGraphics());
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var fig in figures)
                {
                    if (fig.Touch(e.X, e.Y) && fig.enabled == true)
                    {
                        moving = true;
                        figure = fig;
                        dx = e.X - figure.x;
                        dy = e.Y - figure.y;
                        if (fig is Tractor)
                        {
                            Tractor trac = (Tractor)fig;
                            br = new SolidBrush(Color.FromArgb(255 - trac.rec1.color.R, 255 - trac.rec1.color.G, 255 - trac.rec1.color.B));
                            trac.rec1.pen = new Pen(br, 6);
                            br = new SolidBrush(Color.FromArgb(255 - trac.rec2.color.R, 255 - trac.rec2.color.G, 255 - trac.rec2.color.B));
                            trac.rec2.pen = new Pen(br, 6);
                            br = new SolidBrush(Color.FromArgb(255 - trac.ell1.color.R, 255 - trac.ell1.color.G, 255 - trac.ell1.color.B));
                            trac.ell1.pen = new Pen(br, 6);
                            br = new SolidBrush(Color.FromArgb(255 - trac.ell2.color.R, 255 - trac.ell2.color.G, 255 - trac.ell2.color.B));
                            trac.ell2.pen = new Pen(br, 6);
                        }
                        else
                        {
                            br = new SolidBrush(Color.FromArgb(255 - fig.color.R, 255 - fig.color.G, 255 - fig.color.B));
                            fig.pen = new Pen(br, 6);
                        }
                        break;
                    }
                    else
                    {
                        if (fig is Tractor)
                        {
                            Tractor trac = (Tractor)fig;

                            trac.ell1.pen = new Pen(trac.ell2.brush, 1);
                            trac.ell2.pen = new Pen(trac.ell2.brush, 1);
                            trac.rec1.pen = new Pen(trac.rec1.brush, 1);
                            trac.rec2.pen = new Pen(trac.rec2.brush, 1);

                        }
                        else
                        {
                            fig.pen = new Pen(fig.brush, 1);
                        }

                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                foreach (var fig in figures)
                {
                    if (fig.Touch(e.X, e.Y) && fig.enabled == true)
                    {
                        editor.orig = fig;
                        editor.Show();
                        
                        if (fig is Rect)
                        {
                            editor.figure = new Rect(fig.x, fig.y, fig.w, fig.h, fig.color);
                        }
                        if (fig is Ellipse)
                        {
                            editor.figure = new Ellipse(fig.x, fig.y, fig.w, fig.h, fig.color);
                        }
                        if (fig is Tractor)
                        {
                            editor.figure = new Tractor(fig.x, fig.y, fig.w, fig.h, fig.color);
                        }
                        editor.numericUpDown1.Value = (decimal)fig.w;
                        editor.numericUpDown2.Value = (decimal)fig.h;
                    }
                }
            }
            Refresh();
            editor.Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moving = false;
            }
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Можно кароче добавлять эллипсы, прямоугольники и трактора, менять у них цвета и размеры. \nЕщё их можно двигать, сохранять и загружать.");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (moving)
                {
                    figure.Move(e.X - dx, e.Y - dy);
                }
            }
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ch2_Cheked(object sender, EventArgs e)
        {
            CheckBox chek = (CheckBox)sender;
            elipses[(int)chek.Tag].ChangeEnable();
            elipses[(int)chek.Tag].Draw(this.CreateGraphics());
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FLoad();
            Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(figures.Count != 0)
            {
                DialogResult result = MessageBox.Show("Сохранить?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Save();
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ch3_Cheked(object sender, EventArgs e)
        {
            CheckBox chek = (CheckBox)sender;
            tracs[(int)chek.Tag].ChangeEnable();
            tracs[(int)chek.Tag].Draw(this.CreateGraphics());
            Refresh();
        }
        public void Save()
        {
            StreamWriter sw = new StreamWriter("save.txt");

            foreach (var fig in figures)
            {
                if (fig is Rect)
                {
                    sw.WriteLine("1");
                }
                if (fig is Ellipse)
                {
                    sw.WriteLine("2");
                }
                if (fig is Tractor)
                {
                    sw.WriteLine("3");
                }
                sw.WriteLine(fig.x);
                sw.WriteLine(fig.y);
                sw.WriteLine(fig.w);
                sw.WriteLine(fig.h);
                if (fig is Tractor)
                {
                    Tractor trac = (Tractor)fig;
                    sw.WriteLine(trac.rec1.color.ToArgb());
                    sw.WriteLine(trac.rec2.color.ToArgb());
                    sw.WriteLine(trac.ell1.color.ToArgb());
                    sw.WriteLine(trac.ell2.color.ToArgb());
                }
                else
                {
                    sw.WriteLine(fig.color.ToArgb());
                }
                if (fig.enabled)
                {
                    sw.WriteLine("1");
                }
                else
                {
                    sw.WriteLine("0");
                }
            }
            sw.Close();
        }
        public void FLoad()
        {
            if (File.Exists("save.txt"))
            {
                num1 = 0;
                numericUpDown1.Value = 0;
                num2 = 0;
                numericUpDown2.Value = 0;
                num3 = 0;
                numericUpDown3.Value = 0;
                figures.Clear();
                rects.Clear();
                elipses.Clear();
                tracs.Clear();
                for (int i = 0; i < chek1.Count; i++)
                {
                    Controls.Remove(chek1[i]);
                }
                for (int i = 0; i < chek2.Count; i++)
                {
                    Controls.Remove(chek2[i]);
                }
                for (int i = 0; i < chek3.Count; i++)
                {
                    Controls.Remove(chek3[i]);
                }
                chek1.Clear();
                chek2.Clear();
                chek3.Clear();

                StreamReader sr = new StreamReader("save.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line == "1")
                    {
                        Rect r = new Rect((float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), Color.FromArgb(Convert.ToInt32(sr.ReadLine())));
                        r.Draw(this.CreateGraphics());
                        rects.Add(r);
                        figures.Add(r);

                        CheckBox ch = new CheckBox();
                        ch.Width = 20;
                        ch.Location = new Point(90 + 20 * num1, 20);
                        ch.Checked = true;
                        ch.CheckedChanged += new EventHandler(ch1_Cheked);
                        ch.Tag = num1;
                        Controls.Add(ch);
                        chek1.Add(ch);
                        if(sr.ReadLine() == "0")
                        {
                            ch.Checked = false;
                        }

                        num1++;
                        makeFig = false;
                        numericUpDown1.Value += 1;
                        makeFig = true;
                    }
                    if (line == "2")
                    {
                        Ellipse el = new Ellipse((float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), Color.FromArgb(Convert.ToInt32(sr.ReadLine())));
                        el.Draw(this.CreateGraphics());
                        elipses.Add(el);
                        figures.Add(el);

                        CheckBox ch = new CheckBox();
                        ch.Width = 20;
                        ch.Location = new Point(90 + 20 * num2, 58);
                        ch.Checked = true;
                        ch.CheckedChanged += new EventHandler(ch2_Cheked);
                        ch.Tag = num2;
                        Controls.Add(ch);
                        chek2.Add(ch);
                        if (sr.ReadLine() == "0")
                        {
                            ch.Checked = false;
                        }

                        num2++;
                        makeFig = false;
                        numericUpDown2.Value += 1;
                        makeFig = true;
                    }
                    if (line == "3")
                    {
                        Tractor tr = new Tractor((float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()), (float)Convert.ToDouble(sr.ReadLine()),Color.White);

                        tr.Draw(this.CreateGraphics());
                        tracs.Add(tr);
                        figures.Add(tr);
                        tr.rec1.color = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
                        tr.rec2.color = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
                        tr.ell1.color = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
                        tr.ell2.color = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
                        tr.reCreate();

                        CheckBox ch = new CheckBox();
                        ch.Width = 20;
                        ch.Location = new Point(90 + 20 * num3, 94);
                        ch.Checked = true;
                        ch.CheckedChanged += new EventHandler(ch3_Cheked);
                        ch.Tag = num3;
                        Controls.Add(ch);
                        chek3.Add(ch);
                        if (sr.ReadLine() == "0")
                        {
                            ch.Checked = false;
                        }

                        num3++;
                        makeFig = false;
                        numericUpDown3.Value += 1;
                        makeFig = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл был удалён");
            }
        }
    }
}
