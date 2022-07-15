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
        public int player_x = 0;//чтобы анализировать фигню всякую
        public int player_y = 0;
        public int player_dirx = 0;//чтобы анализировать фигню всякую
        public int player_diry = 0;
        
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
        int bullet_area = 20;
        public IBullet flying_bullet = new EmptyBullet();
        Random rnd = new Random();
        public void TakeTurn()
        {
            if (tank.ammo.Count == 0)
            {
                tank.Reload();
                return ;
            }
            bool sovp_x = (player_x - bullet_area <= tank.position[0] && tank.position[0] <= player_x + bullet_area);
            bool sovp_y = (player_y - bullet_area <= tank.position[1] && tank.position[1] <= player_y + bullet_area);
            //если ни на одной координате нет совпадения с игроком
            if (sovp_x == false
                && sovp_y == false)
                ////выбор оптимальной координаты
                //if (Math.Abs(player_x - tank.position[0]) > Math.Abs(player_y - tank.position[1]))
                //Фигня, РАНДОМИМ
                if ((new bool[]{ true,false})[rnd.Next(2)])
                {
                    //если танчик выше
                    if (player_y < tank.position[1])
                    {
                        tank.Move(0, -1);
                    }
                    //если танчик ниже
                    else
                    {
                        tank.Move(0, 1);
                    }
                }
                else
                {
                    //если танчик левее
                    if (player_x < tank.position[0])
                    {
                        tank.Move(-1, 0);
                    }
                    //если танчик правее
                    else
                    {
                        tank.Move(1, 0);
                    }
                }
            //если x координата совпадает, но рейнджи недостаточно по y
            else if (sovp_x && Math.Abs(player_y - tank.position[1]) > 50)
            {

                //если танчик выше
                if (player_y < tank.position[1])
                {
                    tank.Move(0, -1);
                }
                //если танчик ниже
                else
                {
                    tank.Move(0, 1);
                }

            }
            //если y координата совпадает, но рейнджи недостаточно по x
            else if (sovp_y && Math.Abs(player_x - tank.position[0]) > 50)
            {

                //если танчик левее
                if (player_x < tank.position[0])
                {
                    tank.Move(-1, 0);
                }
                //если танчик правее
                else
                {
                    tank.Move(1, 0);
                }

            }
            //СТРЕЛЯЕМ, ПАУ!1111111111
            else
            {
                //если танчик левее
                if (player_x < tank.position[0] && sovp_y)
                {
                    tank.x0 = -1;
                    tank.y0 = 0;
                    flying_bullet = tank.Shoot(tank.x0,tank.y0);
                    t1 = tank.t1;
                    t2 = tank.t2;
                    return;
                    //tank.Move(-1, 0);
                }
                //если танчик правее
                else if (player_x >= tank.position[0] && sovp_y)
                {
                    tank.x0 = 1;
                    tank.y0 = 0;
                    flying_bullet = tank.Shoot(tank.x0, tank.y0);
                    t1 = tank.t1;
                    t2 = tank.t2;
                    return;
                    //tank.Move(1, 0);
                }
                //если танчик выше
                else if (player_y < tank.position[1] &&sovp_x)
                {
                    tank.x0 = 0;
                    tank.y0 = -1;
                    flying_bullet = tank.Shoot(tank.x0, tank.y0);
                    t1 = tank.t1;
                    t2 = tank.t2;
                    return;
                    //tank.Move(0, -1);
                }
                
               
                else
                {
                    tank.x0 = 0;
                    tank.y0 = 1;
                    flying_bullet = tank.Shoot(tank.x0, tank.y0);
                    t1 = tank.t1;
                    t2 = tank.t2;
                    return;
                    //tank.Move(0, 1);
                }

            }
            flying_bullet = new EmptyBullet();
        }
    }
}
