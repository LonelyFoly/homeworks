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
    public interface ISwim
    {
        string Swim();
    }
    public interface IFly
    {
        string Fly();
    }
    public interface IWalk
    {
        string Walk();
    }

    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Height = this.Height;
            pictureBox2.Height = this.Height;
        }

        List<Animal> zoo = new List<Animal>();
        List<String> Female_names = new List<String>() {  "Настя", "Соня", "Аня", };
        List<String> Male_names = new List<String>() { "Аркаша", "Серёжа", "Андрей", "Федя", "Даня", "Марк", "Олег", "Лёша", "Паша" };
        List<String> surnames = new List<String>() { "Летовальцев", "Голубцов", "Панов", "Лобинин", "Кузнецов", "Татаринов", "Бугаев", "Иванов" };
        Random rnd = new Random();

        List<Label> labels = new List<Label>();

        public string Randomize_Name()
        {
            string choose;
            if ((new bool[] { true, false })[rnd.Next(2)])
            {//мальчики
                choose = Male_names[rnd.Next(9)];
                choose += " " + surnames[rnd.Next(8)];
            }
            else
            {//девочбки
                choose = Female_names[rnd.Next(3)];
                choose += " " + surnames[rnd.Next(8)] + "а";
            }
            return choose;
        }
        public int Randomize_Numb(string name)
        {
            int count = 0;
            
            for (int i = zoo.Count()-1; i >=0; i--)
            {
                if (zoo[i].Name == name)
                {
                    count = zoo[i].Number + 1;
                }    
            }


            return count;
        }

        public Point coords;
        public bool dialog_openned = false;
        DialogForm dialog;
        private void label_Click(object sender, EventArgs e)
        {
            if (!dialog_openned)
            {
                int index1 = labels.IndexOf((Label)sender);
                dialog = new DialogForm(this, zoo[index1]);
                dialog_openned = true;
                
                
                dialog.Show();
            }

            
            

        }
        public void Addition(Animal ani)
        {
            zoo.Add(ani);
            Label l = new Label();
            l.Click += new EventHandler(label_Click);
            l.Text = ani.Name;
            if (ani.Number!=0)
            {
                l.Text +=" "+ ani.Number;
            }
            
            l.Size = new Size(120, 20);
            l.Location = new Point(300, 50 + labels.Count() * 25);
            Controls.Add(l);
            labels.Add(l);
        }

        private void button_OctoSpawn_Click(object sender, EventArgs e)
        {
            string name = Randomize_Name();
            int numb = Randomize_Numb(name);
            Animal ani = new Octopus(name, numb);

            Addition(ani);
            

            
        }

        private void button_DuckSpawn_Click(object sender, EventArgs e)
        {
            string name = Randomize_Name();
            int numb = Randomize_Numb(name);
            Animal ani = new Duck(name, numb);

            Addition(ani);
        }

        private void button_CatSpawn_Click(object sender, EventArgs e)
        {
            string name = Randomize_Name();
            int numb = Randomize_Numb(name);

            Animal ani = new Cat(name, numb);

            Addition(ani);
        }

        private void button_BatSpawn_Click(object sender, EventArgs e)
        {
            string name = Randomize_Name();
            int numb = Randomize_Numb(name);

            Animal ani = new Bat(name, numb);

            Addition(ani);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Height = this.Height;
            pictureBox2.Height = this.Height;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
