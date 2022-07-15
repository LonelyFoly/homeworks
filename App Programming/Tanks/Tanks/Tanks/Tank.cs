using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Tank
    {
        public int size = 20;
        public ITankBody body =new MidTankBody();//для реализации других тел танков, которым присвоен данный интерфейс
        public List<IBullet> ammo =new List<IBullet>() {new MidBullet(), new MidBullet() , new MidBullet() };//видимо, для создания специфических СУПЕРПУЛЬ!
        
        public int health=100;
        public int speed = 50;
        public int[] position = new int[2];


        int area = 500;
        public int x0, y0;//направление взгляда для выстрела
        public Tank(int x,int y)
        {
            position[0] = x;
            position[1] = y;
        }
        public void Move(int x, int y)
        {//x=1 - вправо, y=-1 - вверх
            //x=0, y= 0 - никуда
            x0 = x;
            y0 = y;
            position[0] += Convert.ToInt32(speed / body.weight) * x ;
            position[1] += Convert.ToInt32(speed / body.weight) * y;
            //проверка выезда за карту
            if (position[0] < 0) position[0] = 0;
            if (position[0] > area-size) position[0] = area-size;
            if (position[1] < 0 ) position[1] = 0;
            if (position[1] > area - size) position[1] = area - size;
            //Console.WriteLine("x= "+position[0]+"  y= "+ position[1]);
        }
        public void GetHit(IBullet bullet)
        {
            health -=bullet.damage/body.hardness;
            Console.WriteLine("АЙ");
            Console.WriteLine("HP: "+health);
        }
        public int[] t1 = new int[2];//начало отрезка стрельбы
        public int[] t2 = new int[2];//конец отрезка стрельбы
        public IBullet Shoot(int x, int y)//мб при выстреле делать только реализацию убирания пули в самом танке?
        {
            x0 = x;
            y0 = y;
            if (ammo.Count == 0) return new EmptyBullet();

            t1 = position;
            t2[0] = position[0] + x * ammo[ammo.Count() - 1].range;
            t2[1] = position[1] + y * ammo[ammo.Count() - 1].range;
            IBullet n = ammo[ammo.Count() - 1];
            ammo.RemoveAt(ammo.Count() - 1);
            //Console.WriteLine("БАХ");
            return n;
        }
        List<IBullet> choose_bullet = new List<IBullet>() { new ShortBullet(), new MidBullet(), new LongBullet() };
        Random rnd = new Random();
        public void Reload()
        {

            ammo = new List<IBullet>() { choose_bullet[rnd.Next(3)], choose_bullet[rnd.Next(3)], choose_bullet[rnd.Next(3)] };
        }
    }
}
