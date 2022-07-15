using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class TankController
    {
        public Tank tank;
        public bool alive = true;//проверка так же на конец игры для данного игрока
        public int[] t1 = new int[2];//начало отрезка стрельбы
        public int[] t2 = new int[2];//конец отрезка стрельбы
        Image img;
        public TankController(int x, int y, Image img_)
        {
            tank=new Tank(x, y);
            img = img_;
            img0 = img_;
        }
        public Image img0;
        public int[] Draw()

        {
            
            img0.RotateFlip(RotateFlipType.RotateNoneFlipY);
            img0 = (Image)img.Clone();
            if (tank.x0 == 1)
                img0.RotateFlip(RotateFlipType.Rotate270FlipNone);
            else if (tank.x0 == -1)
                img0.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (tank.y0 == -1)
            { }
            else if (tank.y0 == 1)
                img0.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return tank.position;
           // g.DrawRectangle(new Pen(Color.Black), tank.position[0], tank.position[1], tank.size, tank.size);
        }
        Random rnd = new Random();
        public void Hit(IBullet bullet)//принмает пулю от другого танка
                                       //передаётся IBullet, чтобы её обрабатывать в дальнейшем
        {

            if (rnd.Next(1) == 0)//сейчас вероятность 100% попадания

                tank.GetHit(bullet);
            if (tank.health <= 0)
                alive = false;
        }
        public void TankReload()
        {
            tank.Reload();
        }
        public int[] TankLocation()
        {
            return tank.position;
        }
        public int[] TankDirection()
        {
            int[] a = new int[] { tank.x0, tank.y0 };
            return a;
        }
        public int TankHealth()
        {
            return tank.health;
        }
        public string[] TankAmmo()
        {
            string[] ammo = new string[3] { "","",""};//3 - количество пуль
            int i = 0;
            foreach (var item in  tank.ammo) 
            {
                if (tank.ammo[i] is ShortBullet)
                    ammo[i] = "Short";
                else if (tank.ammo[i] is MidBullet)
                    ammo[i] = "Mid";
                else if (tank.ammo[i] is LongBullet)
                    ammo[i] = "Long";
                else
                    ammo[i] = "";
                i++;
            }
            return ammo;
        }
    }
}
