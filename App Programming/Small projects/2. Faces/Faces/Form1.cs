using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faces
{
    public partial class Form1 : Form
    {
        List<Face> faces = new List<Face>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Face face = new Face(e.X, e.Y, rnd.Next(100,200));
            faces.Add(face);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var f in faces)
            {
                f.Draw(e.Graphics);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var f in faces)
            {
                f.Update(e.X, e.Y);
            }
            Refresh();
        }
    }
}
