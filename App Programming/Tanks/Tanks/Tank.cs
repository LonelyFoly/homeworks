using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Tank
    {
        int size = 20;
        ITankBody body = new MidTankBody();//для реализации других тел танков, которым присвоен данный интерфейс
        List<IBullet> ammo =new List<IBullet>() {new MidBullet(), new MidBullet() , new MidBullet() };//видимо, для создания специфических СУПЕРПУЛЬ!
        int health=100;
        int speed = 50;
        int step = 0;
        Point position;
        int x0, y0;//направление взгляда для выстрела
        public int Size { get { return size; } }
        public int direction_x0 { get { return x0; } set { x0 = value; } }
        public int direction_y0 { get { return y0; } set { y0 = value; } }
        public Point Position { get { return position; } }
        public bool IsEmpty { get { return ammo.Count() == 0; } }
        public int Health { get { return health; } }
        public ITankBody changeBody { get { return body; } set { body = value; } }

        public Tank(int x,int y)
        {
            position = new Point(x, y);
            step = Convert.ToInt32(speed / body.weight);
        }
        public void Move(int x, int y)
        {//x=1 - вправо, y=-1 - вверх
            //x=0, y= 0 - никуда
            x0 = x;
            y0 = y;
            
            position.X += step * x ;
            position.Y += step * y;
            //проверка выезда за карту**
            
            //if (position.X < 0) position.X = 0;
            //if (position.X > actualArea - size) position.X = actualArea - size;
            //if (position.Y < 0 ) position.Y = 0;
            //if (position.Y > actualArea - size) position.Y = actualArea - size;
            //Console.WriteLine("x= "+position[0]+"  y= "+ position[1]);
        }
        //public bool IsOutOfMap ()
        //{
        //    int actualArea = Tools.Info();
        //    bool check = ((position.X < 0) || (position.X > actualArea - size) || (position.Y < 0) || (position.Y > actualArea - size));
        //   // Console.WriteLine("Вне карты: ", check);
        //    return check;
        //}
        public void GetHit()
        {
            IBullet bullet = Tools.BulletInfo;
            health -=bullet.damage/body.hardness;
            //Console.WriteLine("АЙ");
            //Console.WriteLine("HP: "+health);
        }
        
        public void Shoot(int x, int y)
        {
            if (ammo.Count == 0)//*
            {
                Tools.BulletCatcher(new Point(-1, -1), new Point(-1, -1), new EmptyBullet());
                return;
            }
            x0 = x;
            y0 = y;
            int dop_x = position.X + x * ammo[ammo.Count() - 1].range;
            int dop_y = position.Y + y * ammo[ammo.Count() - 1].range;
            IBullet dop_bullet = ammo[ammo.Count() - 1];

            Tools.BulletCatcher(position,new Point(dop_x,dop_y),dop_bullet);
            ammo.RemoveAt(ammo.Count() - 1);
            //Console.WriteLine("БАХ");
            return;
        }
        //List<IBullet> choose_bullet = new List<IBullet>() { new ShortBullet(), new MidBullet(), new LongBullet() };
        //Random rnd = new Random();
        public void Reload()
        {
            ammo = new List<IBullet>() { Tools.ReturnRandomBullet(), Tools.ReturnRandomBullet(), Tools.ReturnRandomBullet() };
        }
        public List<IBullet> ReturnBulls()
        {
            return ammo;
        }
    }
}
