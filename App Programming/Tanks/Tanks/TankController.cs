using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    abstract class TankController
    {
        protected Tank tank;
       // bool alive = true;
        Image img0,img;
        //public IBullet flying_bullet = new EmptyBullet();
        public TankController(int x, int y, Image img_)
        {
            tank=new Tank(x, y);
            img = img_;
            img0 = img_;
        }
        
        public Image image {get{ return img0; } }
        public bool IsAlive { get => (TankHealth() > 0); }
        public Point Draw()
        {
            img0.RotateFlip(RotateFlipType.RotateNoneFlipY);
            img0 = (Image)img.Clone();
            if (tank.direction_x0 == 1)
                img0.RotateFlip(RotateFlipType.Rotate270FlipNone);
            else if (tank.direction_x0 == -1)
                img0.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (tank.direction_y0 == -1)
                { }
            else if (tank.direction_y0 == 1)
                img0.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return tank.Position;
           // g.DrawRectangle(new Pen(Color.Black), tank.position[0], tank.position[1], tank.size, tank.size);
        }
        public void TankShoot(int x, int y)
        {
            tank.Shoot(x, y);
        }
        public bool IsOutOfMap()
        {
            int actualArea = Tools.Info();
            int size = tank.Size;
            bool check = ((tank.Position.X < 0) || (tank.Position.X > actualArea - size) || (tank.Position.Y < 0) || (tank.Position.Y > actualArea - size));
            return check;
        }
        public void TankMove(int x, int y)
        {//x, y - направление взгляда
         //shoot and move убрать
            tank.Move(x, y);
            if (/*tank.*/IsOutOfMap())
            {
                tank.Move(-x, -y);
            }
        }
        Random rnd = new Random();
        public void Hit()
                                      
        {
            IBullet flying_bullet = Tools.BulletInfo;

            if (rnd.Next(1) == 0)//сейчас вероятность 100% попадания
                //if (!(flying_bullet is EmptyBullet))
                {
                        int bullet_area = flying_bullet.bullet_area;
                        Point t1 = Tools.RangeInfo()[0];
                        Point t2 = Tools.RangeInfo()[1];

                        Point shootedPosition = TankLocation();
                    int[] shootingDirection = new int[2]; //= TankDirection();
                        if (t1.X < t2.X) { shootingDirection[0] = 1; shootingDirection[1] = 0; }
                    if (t1.X > t2.X) { shootingDirection[0] = -1; shootingDirection[1] = 0; }
                    if (t1.Y < t2.Y) { shootingDirection[0] = 0; shootingDirection[1] = 1; }
                    if (t1.Y > t2.Y) { shootingDirection[0] = 0; shootingDirection[1] = -1; }
                    //если стреляю вверх или вниз
                    if (t1.X == t2.X)//всё правильно, не трогай
                        {
                            //проверка по ширине траектории
                            if ((t1.X + bullet_area >= shootedPosition.X) && (t1.X - bullet_area <= shootedPosition.X))
                            {
                                //если стрелять вверх
                                if (((t1.Y + bullet_area >= shootedPosition.Y) && (t2.Y - bullet_area <= shootedPosition.Y) && shootingDirection[1] == -1)
                                    //если стрелять вниз
                                    || ((t1.Y - bullet_area <= shootedPosition.Y) && (t2.Y + bullet_area >= shootedPosition.Y) && shootingDirection[1] == 1))
                                {
                                    tank.GetHit();//добавить систему попадания в ближайшего, если 2+ игроков
                                    
                                }

                            }
                        }
                        //если стреляю вправо или влево
                        if (t1.Y == t2.Y)
                        {
                            //проверка по ширине траектории
                            if ((t1.Y + bullet_area >= shootedPosition.Y) && (t1.Y - bullet_area <= shootedPosition.Y   ))
                            {
                                //если стрелять влево
                                if (((t1.X + bullet_area >= shootedPosition.X) && (t2.X - bullet_area <= shootedPosition.X) && shootingDirection[0] == -1)
                                    //если стрелять вправо
                                    || ((t1.X - bullet_area <= shootedPosition.X) && (t2.X + bullet_area >= shootedPosition.X) && shootingDirection[0] == 1))
                                {
                                tank.GetHit();

                            }

                            }
                        }
                    
                }
           
            //if (tank.Health <= 0)
            //    alive = false;
        }
        public void TankReload()
        {
            tank.Reload();
        }
        public Point TankLocation()
        {
            return tank.Position;
        }
        public int[] TankDirection()
        {
            int[] a = new int[] { tank.direction_x0, tank.direction_y0 };
            return a;
        }
        public int TankHealth()
        {
            return tank.Health;
        }

        public string[] TankAmmo()
        {
            string[] ammo = new string[3] { "","",""};//3 - количество пуль
            int i = 0;
            List<IBullet> array_ammo = tank.ReturnBulls();

            foreach (var item in array_ammo) 
            {
                if (array_ammo[i] is ShortBullet)
                    ammo[i] = "Short";
                else if (array_ammo[i] is MidBullet)
                    ammo[i] = "Mid";
                else if (array_ammo[i] is LongBullet)
                    ammo[i] = "Long";
                else
                    ammo[i] = "";
                i++;
            }
            return ammo;
        }
    }
}
