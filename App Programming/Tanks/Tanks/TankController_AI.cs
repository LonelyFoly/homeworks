using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class TankController_AI:TankController
    {   
        public TankController_AI(int x, int y, Image img_) : base(x, y,img_) { }

        int player_x = 0;//чтобы анализировать фигню всякую
        int player_y = 0;
        int player_dirx = 0;//чтобы анализировать фигню всякую
        int player_diry = 0;
        
       public void InfoGetter (int player_x0, int player_y0, int player_dirx0, int player_diry0)
        {
            player_x = player_x0;
            player_y = player_y0;
            player_dirx = player_dirx0;
            player_diry = player_diry0;
        }

        bool shoot=false;
        public bool IWantToShoot
        {
            get{
                bool t = shoot;
                shoot = false;
                return t; }
        }
        
        Random rnd = new Random();
        public void TakeTurn()
        {
            if (tank.IsEmpty)
            {
                TankReload();
                return ;
            }
            Point Position = tank.Position;
            int bullet_area = Tools.BulletInfo.bullet_area;
            bool sovp_x = (player_x - bullet_area <= Position.X && Position.X <= player_x + bullet_area);
            bool sovp_y = (player_y - bullet_area <= Position.Y && Position.Y <= player_y + bullet_area);
            //если ни на одной координате нет совпадения с игроком
            if (sovp_x == false
                && sovp_y == false)
                ////выбор оптимальной координаты
                //if (Math.Abs(player_x - tank.position[0]) > Math.Abs(player_y - tank.position[1]))
                //Фигня, РАНДОМИМ
                if ((new bool[]{ true,false})[rnd.Next(2)])
                {
                    //если танчик выше
                    if (player_y < Position.Y) TankMove(0, -1);
                    //если танчик ниже
                    else TankMove(0, 1);
                }
                else
                {
                    //если танчик левее
                    if (player_x < Position.X) TankMove(-1, 0);
                    //если танчик правее
                    else TankMove(1, 0);
                }
            //если x координата совпадает, но рейнджи недостаточно по y
            else if (sovp_x && Math.Abs(player_y - Position.Y) > 50)
            {

                //если танчик выше
                if (player_y < Position.Y) TankMove(0, -1);
                //если танчик ниже
                else TankMove(0, 1);


            }
            //если y координата совпадает, но рейнджи недостаточно по x
            else if (sovp_y && Math.Abs(player_x - Position.X) > 50)
            {

                //если танчик левее
                if (player_x < Position.X) TankMove(-1, 0);
                //если танчик правее
                else TankMove(1, 0);

            }
            //СТРЕЛЯЕМ, ПАУ!1111111111
            else
            {
                //если танчик левее
                if (player_x < Position.X && sovp_y)
                {
                    tank.direction_x0 = -1;
                    tank.direction_y0 = 0;
                    shoot = true;
                    tank.Shoot(tank.direction_x0, tank.direction_y0);
                    return;
                    //tank.Move(-1, 0);
                }
                //если танчик правее
                else if (player_x >= Position.X && sovp_y)
                {
                    tank.direction_x0 = 1;
                    tank.direction_y0 = 0;
                    shoot = true;
                    tank.Shoot(tank.direction_x0, tank.direction_y0);
                    return;
                    //tank.Move(1, 0);
                }
                //если танчик выше
                else if (player_y < Position.Y && sovp_x)
                {
                    tank.direction_x0 = 0;
                    tank.direction_y0 = -1;
                    shoot = true;
                    tank.Shoot(tank.direction_x0, tank.direction_y0);
                    return;
                    //tank.Move(0, -1);
                }
                else
                {
                    tank.direction_x0 = 0;
                    tank.direction_y0 = 1;
                    shoot = true;
                    tank.Shoot(tank.direction_x0, tank.direction_y0);
                    return;
                    //tank.Move(0, 1);
                }
            }
            //flying_bullet = new EmptyBullet();
        }
    }
}
