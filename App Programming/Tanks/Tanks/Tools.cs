using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    public static class Tools
    {
        static Game GameInfo = new Game();
        public static int Info() { return GameInfo.AreaGet; }
        public static void BulletCatcher(Point t1_, Point t2_, IBullet flying_bullet_)
        {
            t1 = t1_;
            t2 = t2_;
            //Console.WriteLine("Координата пули: " + Convert.ToString(t1) + " " + Convert.ToString(t2));
            flying_bullet = flying_bullet_;
        }

        public static Point[] RangeInfo()
        {
            return new Point[2] { t1, t2 };
        }
        public static IBullet BulletInfo
        {
            get { return flying_bullet; }
        }
        static Point t1;//начало отрезка стрельбы
        static Point t2;//конец отрезка стрельбы
        static IBullet flying_bullet = new EmptyBullet();
        static Image im1, im2;
        public static Image image1 { get { return im1; } set { im1 = value; } }
        public static Image image2 { get { return im2; } set { im2 = value; } }
        static Random rnd = new Random();
        static List<IBullet> choose_bullet = new List<IBullet>() { new ShortBullet(), new MidBullet(), new LongBullet() };
        public static IBullet ReturnRandomBullet()
        {
            return choose_bullet[rnd.Next(3)];
        }
    }
}
