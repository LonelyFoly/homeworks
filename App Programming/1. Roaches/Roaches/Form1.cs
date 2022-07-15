using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Roaches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Game Race= new Game();
        bool InProgress;
        private void bStart_Click(object sender, EventArgs e)
        {
            if (InProgress && !timer1.Enabled)
            {
                Race.ToDefault();
            }

            if (Race.Roaches.Count != 0)
            {
                InProgress = true;
                timer1.Start();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            Race.Draw(e.Graphics);
           
        }

        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Race.Action();
            if (Race.Check())
            {
                timer1.Stop();
                if (Race.WIN(stavka))
                {
                    score += 10;
                }
                else
                    score -= 10;
                label_score.Text = Convert.ToString(score);
            }
            Refresh();
        }


        int old_num = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int new_num = Convert.ToInt32(numericUpDown1.Value);

            if ((new_num > 5) && (new_num < 0))
            {
                numericUpDown1.Value = old_num;
                return;
            }


            if (new_num > old_num)
                Race.Create();
            else
                Race.Remove();



            old_num = new_num;
            Race.ToDefault();
            timer1.Stop();
            Refresh();
        }
        int stavka = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled) textBox1.Text = "";
                stavka = Convert.ToInt32(textBox1.Text);
                
            }
            catch
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Race.Reload();
        }
    }
}
