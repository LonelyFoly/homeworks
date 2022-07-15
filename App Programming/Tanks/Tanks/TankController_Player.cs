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

        public void TakeTurn (int x0, int y0, bool shoot, bool move, bool reload)
        {
            if (shoot)
            {
                TankShoot(x0,y0);//Происходит выстрел без возрата (если верить новой системе через Tools)
            }
            else if (move)
            {
                TankMove(x0, y0);
                //Tools.flying_bullet = new EmptyBullet();
            }
            else if (reload)
            {
                TankReload();
                //Tools.flying_bullet = new EmptyBullet();
            }    
        }
        public void ChangeBody(string item)
        {
            if (item == "Middle")
                tank.changeBody = new MidTankBody();
            if (item == "Light")
                tank.changeBody = new LightTankBody();
            if (item == "Heavy")
                tank.changeBody = new HeavyTankBody();
        } 
    }
}

