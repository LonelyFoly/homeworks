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
using System.Text.Json;
using System.Text.Json.Serialization;



namespace Series
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
        int img;
        public string Randomize_Name_Image()
        {
            string choose;
            
            if ((new bool[] { true, false })[rnd.Next(2)])
            //мальчики
            {
                choose = male_names[rnd.Next(0, male_names.Count)];
                img = rnd.Next(icons.Count /2, icons.Count);
            }
            else
            {
                //девочбки
                choose = female_names[rnd.Next(0, female_names.Count)];
                img = rnd.Next(0, icons.Count/2);
            }
            return choose;
        }
        public int Randomize_Numb(string name)
        {
            int numb = 0;

            //if (male_names.IndexOf(name)!=-1 && male_names.Count() != 0) 
                foreach (var item in garem)
                {
                    if (name == item.Name)
                        numb += 1;
                }
                 


            return numb;
        }
        List<Character> garem = new List<Character>();
        Random rnd = new Random();  
        List<String> female_names = new List<String>() { "Настя", "Соня", "Аня", };
        List<String> male_names = new List<String>() { "Аркаша", "Серёжа", "Андрей", "Федя", "Даня", "Марк", "Олег", "Лёша", "Паша" };
        List<Image> icons= new List<Image>(){Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._10, Properties.Resources._11, Properties.Resources._12, };
        private void button_Add_Click(object sender, EventArgs e)
        {


            string name = Randomize_Name_Image();
            int numb = Randomize_Numb(name);

            Character temp = new Character();
            temp.Name = name;
            temp.Number = numb;
            temp.Portret = img;
            int t1 = rnd.Next(1, 29);
            int t2 = rnd.Next(1, 13);
            string s1 = "";
            string s2 = "";

            if (t1 < 10) s1 += "0";
            if (t2 < 10) s2 += "0";
            s1 += t1;
            s2 += t2;
            temp.Birthday =s1 +"."+ s2 + "." + Convert.ToString(rnd.Next(1995, 2021));
            temp.Hobby = (new string[] { "Футбол", "Баскетбол", "Игра на гитаре", "Кулинария", "Видеоигры", "Рисование", "Пение", "Стихи" })[rnd.Next(8)];
            temp.Town=(new string[] { "Кимры", "Дубна", "Москва", "Великие Луки", "Ижевск", "Лобня", "Хохотуй", "Киев" })[rnd.Next(8)];

            garem.Add(temp);
            string s = temp.Name;
            if (temp.Number != 0) s += " " + temp.Number;
            listBox1.Items.Add(s); 
        }
        Character c;
        private void button_Save_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@".\save.txt");
            //StreamWriter sw = new StreamWriter(@".\save.txt");
            //c = new Character();
            //c.Name = "123";
            //c.Number = 123;
            
            string jsonString = JsonSerializer.Serialize<List<Character>>(garem);
            //string jsonString = JsonSerializer.Serialize(garem);
            File.WriteAllText(@".\save.txt", jsonString);
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(@".\save.txt");
            //garem = JsonSerializer.Deserialize<List<Character>>(jsonString);
            garem = JsonSerializer.Deserialize<List<Character>>(jsonString);
            if (garem.Count == 0) return;
            listBox1.Items.Clear();
            foreach(var temp in garem)
            {
                string s = temp.Name;
                if (temp.Number != 0) s += " " + temp.Number;
                listBox1.Items.Add(s);
            }
        }
        Character temp;
        int selected=-1;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected=listBox1.SelectedIndex;
            if (listBox1.SelectedIndex == -1) return;
            temp = garem[listBox1.SelectedIndex];
            portretBox.BackgroundImage = icons[temp.Portret];
            portretBox.Visible = true;
            textBox_GlobalInfo.Visible = true;
            
            button3.Visible = true;
            textBox_Talk.Visible = true;
            label1.Text = "Привет! Моё имя ";
            label_Name.Text =  temp.Name;
            label2.Text = "День рождения: " ;
            label_Birthday.Text =  temp.Birthday;
            label3.Text = "Родной город: ";

            label_Town.Text = temp.Town;
            label4.Text = "Хобби: ";
            label_Hobby.Text =  temp.Hobby;
            
        }
        List<TextBox> list_boxes = new List<TextBox>();
        private void label_Name_Click(object sender, EventArgs e)
        {
            label_Name.Visible = false;
            TextBox t = new TextBox();
            t.Size = label_Name.Size;
            t.Location = label_Name.Location;
            t.Text = label_Name.Text;
            t.TextChanged += T_TextChanged_Name;
            panel1.Controls.Add(t);
            list_boxes.Add(t);
            //Controls.Add(t);
        }

        private void T_TextChanged_Name(object sender, EventArgs e)
        {
            label_Name.Text = ((TextBox)sender).Text;
            temp.Name = ((TextBox)sender).Text;
            listBox1.Items[selected] = ((TextBox)sender).Text;
        }

        private void label_Birthday_Click(object sender, EventArgs e)
        {
            label_Birthday.Visible = false;
            TextBox t = new TextBox();
            t.Size = label_Birthday.Size;
            t.Location = label_Birthday.Location;
            t.Text = label_Birthday.Text;
            t.TextChanged += T_TextChanged_Birthday;
            list_boxes.Add(t);
            panel1.Controls.Add(t);
        }
        private void T_TextChanged_Birthday(object sender, EventArgs e)
        {
            label_Birthday.Text = ((TextBox)sender).Text;
            temp.Birthday = ((TextBox)sender).Text;
        }

        private void label_Town_Click(object sender, EventArgs e)
        {
            label_Town.Visible = false;
            TextBox t = new TextBox();
            t.Size = label_Town.Size;
            t.Location = label_Town.Location;
            t.Text = label_Town.Text;
            t.TextChanged += T_TextChanged_Town;
            list_boxes.Add(t);
            panel1.Controls.Add(t);
        }
        private void T_TextChanged_Town(object sender, EventArgs e)
        {
            label_Town.Text = ((TextBox)sender).Text;
            temp.Town = ((TextBox)sender).Text;
        }
        private void label_Hobby_Click(object sender, EventArgs e)
        {
            label_Hobby.Visible = false;
            TextBox t = new TextBox();
            t.Size = label_Hobby.Size;
            t.Location = label_Hobby.Location;
            t.Text = label_Hobby.Text;
            t.TextChanged += T_TextChanged_Hobby;
            list_boxes.Add(t);
            panel1.Controls.Add(t);
        }

        private void T_TextChanged_Hobby(object sender, EventArgs e)
        {
            label_Hobby.Text = ((TextBox)sender).Text;
            temp.Hobby = ((TextBox)sender).Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor!=Color.Salmon)
            {
                button3.BackColor = Color.Salmon;
                label_Hobby.Visible = true;
                label_Town.Visible = true;
                label_Name.Visible = true;
                label_Birthday.Visible = true;
                foreach (var item in list_boxes)
                {
                    
                    panel1.Controls.Remove(item);
                }
                list_boxes = new List<TextBox>();
            }
            else
            {
                button3.BackColor = Color.Maroon;
            }    
                
            label_Name.Enabled =!label_Name.Enabled;
            label_Town.Enabled = !label_Town.Enabled;
            label_Birthday.Enabled = !label_Birthday.Enabled;
            label_Hobby.Enabled = !label_Hobby.Enabled;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
