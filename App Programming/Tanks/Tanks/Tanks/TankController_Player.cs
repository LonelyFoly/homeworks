using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class TankController_Player:TankController
    {

        public TankController_Player(int x, int y,Image img_) : base(x, y, img_) { }


        public IBullet Shoot(int x, int y)
        {
            IBullet bullet = tank.Shoot(x, y);
            t1 = tank.t1;
            t2 = tank.t2;
            return bullet;
        }
        public void Move(int x, int y)
        {//x, y - направление взгляда
         //shoot and move убрать
            tank.Move(x, y);

        }
        public void ChangeBody(string item)
        {
            if (item == "Middle")
                tank.body =new MidTankBody();
            if (item == "Light")
                tank.body = new LightTankBody();
            if (item == "Heavy")
                tank.body = new HeavyTankBody();
            Console.WriteLine("Тело танка игрока: "+tank.body);
        }



        
    }
}

