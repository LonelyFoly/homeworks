using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    //починить звёздочки
    //позишн игрока через какой-нибудь статик мб? хз хз
    //Починить паблик интерфейс с помощью перевода пули в строку в промежуточных значениях
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Game game = new Game();
        public Game GameReader {get => game;}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_turn_Tick(object sender, EventArgs e)
        {
            game.NextTurn(shoot,move,reload,x,y);
            if (game.CheckWin())
            {
                timer_turn.Enabled = false;
                MessageBox.Show("КОНЕЦ ИГРЫ");
                
            }
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_turn.Enabled = true;
            comboBox1.Enabled = false;
        }


        bool move = true;
        bool shoot = false;
        bool reload = false;
        int x = 1;
        int y = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Down || e.KeyValue == (char)Keys.S)
            {
                move = true;
                shoot = false;
                reload = false;
                y = 1;
                x = 0;
            }
            if (e.KeyValue == (char)Keys.Up || e.KeyValue == (char)Keys.W)
            {
                move = true;
                shoot = false;
                reload = false;
                y = -1;
                x = 0;
            }
            if (e.KeyValue == (char)Keys.Right || e.KeyValue == (char)Keys.D)
            {
                move = true;
                shoot = false;
                reload = false;
                x = 1;
                y = 0;
            }
            if (e.KeyValue == (char)Keys.Left || e.KeyValue == (char)Keys.A)
            {
                move = true;
                shoot = false;
                reload = false;
                x = -1;
                y = 0;
            }
            if (e.KeyValue == (char)Keys.Space)
            {
                move = false;
                shoot = true;
                reload = false;

            }
            if (e.KeyValue == (char)Keys.R)
            {
                move = false;
                shoot = false;
                reload = true;

            }
        }
        int[] health = new int[2];
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] a = game.Draw();

            pictureBox_Enemy.BackgroundImage = Tools.image1;
            pictureBox_Player.BackgroundImage = Tools.image2;
            pictureBox_Enemy.Location = a[0];
            pictureBox_Player.Location = a[1];

            e.Graphics.DrawLine(new Pen(Color.Black),0,500,500,500);
            e.Graphics.DrawLine(new Pen(Color.Black), 500, 0, 500, 500);


            health = game.ControllersHealth();

            label_health_enemy.Text = Convert.ToString(health[0]);
            label_health_player.Text = Convert.ToString(health[1]);

            string[][] ammo = game.ControllersAmmo();

            label_aa_1.Text = ammo[0][0];
            label_aa_2.Text = ammo[0][1];
            label_aa_3.Text = ammo[0][2];

            label_ap_1.Text = ammo[1][0];
            label_ap_2.Text = ammo[1][1];
            label_ap_3.Text = ammo[1][2];
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Мышка: x= " + e.X + "  y= " + e.Y);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.ChangeBody(comboBox1.SelectedItem.ToString());
        }
    }
}
