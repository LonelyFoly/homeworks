using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Zoo
{
    public partial class DialogForm : Form
    {
        Animal ani;
        public DialogForm(Form1 form_input, Animal ani_)
        {
            InitializeComponent();
            form = form_input;
            ani = ani_;
            int i = 0;
            if (!(ani is ISwim))
                buttonSwim.Hide();
            else
            {
                buttonSwim.Location = new Point(185, 9 + 28 * i);
                i++;
            }
            if (!(ani is IWalk))
                buttonWalk.Hide();
            else
            {
                buttonWalk.Location = new Point(185, 9 + 28 * i);
                i++;
            }
            if (!(ani is IFly))
                buttonFly.Hide();
            else
            {
                buttonFly.Location = new Point(185, 9 + 28 * i);
                i++;
            }

            if (ani is Octopus)
                pictureBox1.BackgroundImage = The_Zoo.Properties.Resources.octopus;
            if (ani is Cat)
                pictureBox1.BackgroundImage = The_Zoo.Properties.Resources.Cat;
            if (ani is Duck)
                pictureBox1.BackgroundImage = The_Zoo.Properties.Resources.Duck;
            if (ani is Bat)
                pictureBox1.BackgroundImage = The_Zoo.Properties.Resources.Bat;
            //Button l = new Label();
            //l.Click += new EventHandler(label_Click);
            //l.Text = ani.Name;
            //if (ani.Number != 0)
            //{
            //    l.Text += " " + ani.Number;
            //}

            //l.Size = new Size(120, 20);
            //l.Location = new Point(300, 50 + labels.Count() * 25);
            //Controls.Add(l);
            //labels.Add(l);

        }

        Form1 form;
        private void DialogForm_Load(object sender, EventArgs e)
        {
            this.Location = form.coords;
            label1.Text = ani.Name;
            if (ani.Number!=0)
            {
                label1.Text += " #" + ani.Number;
            }
            
        }


        private void DialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.dialog_openned = false;
            form.coords = this.Location;
        }

        private void buttonSwim_Click(object sender, EventArgs e)
        {
            textBox.Text= (ani as ISwim).Swim();
        }

        private void buttonWalk_Click(object sender, EventArgs e)
        {
            textBox.Text = (ani as IWalk).Walk();
        }

        private void buttonFly_Click(object sender, EventArgs e)
        {
            textBox.Text = (ani as IFly).Fly();
        }

        private void buttonTalk_Click(object sender, EventArgs e)
        {
            textBox.Text = ani.Talk();
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            textBox.Text = ani.Type();
        }
    }
}
