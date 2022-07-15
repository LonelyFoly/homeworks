using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Game
    {
        int size = 600;//размер поля = size x size
        List<TankController> players = new List<TankController>() {new TankController_AI(550,550, Properties.Resources._1), new TankController_Player(0,0, Properties.Resources._2) };
        public bool CheckWin()
        {
            foreach (var actualPlayer in players)
            {
                if (actualPlayer.alive == false)
                    return true;
                
            }
            return false;
        }
        public Image im1, im2;
        public int[][] Draw ()
        {
            im1 = players[0].img0;//AI
            im2= players[1].img0;//PLAYER
            int[][] a = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                a[i] =players[i].Draw();
                
            }
            return a;
        }
        public void ChangeBody(string item)
        {
            ((TankController_Player)players[1]).ChangeBody(item);
        }
        public int[] ControllersHealth()
        {
            int[] health = new int[players.Count];
            for (int i = 0; i < players.Count; i++)
            {
                health[i] = players[i].TankHealth();

            }
            return health;
        }
        public string[][] ControllersAmmo()
        {
            string[][] ammo = new string[2][];
            for (int i = 0; i < 2; i++)
            {
                ammo[i] = players[i].TankAmmo();
            }
            return ammo;
        }
        int bullet_area = 20;//ширина пули (половина размера танка)

        public void NextTurn(bool shoot, bool move, bool reload, int x, int y)
        {
            
            foreach (var actualPlayer in players)
            {
                if (actualPlayer is TankController_Player)
                {
                    var actualPlayer1 = (TankController_Player)actualPlayer;
                    IBullet flyingBullet;
                    if (shoot)
                    {
                        flyingBullet = actualPlayer1.Shoot(x,y);// else flyingBullet = new EmptyBullet(); 
                        if (flyingBullet is EmptyBullet) break;
                        int[] t1 = actualPlayer1.t1;//начало отрезка стрельбы
                        int[] t2 = actualPlayer1.t2;
                        foreach (var shootedPlayer in players)
                        {
                            
                            if (actualPlayer == shootedPlayer) continue;

                            int[] shootedPosition = shootedPlayer.TankLocation();
                            int[] shootingDirection = actualPlayer.TankDirection();
                            //если стреляю вверх или вниз
                            if (t1[0] == t2[0])//всё правильно, не трогай
                            {
                                //проверка по ширине траектории
                                if ((t1[0] + bullet_area >= shootedPosition[0]) && (t1[0] - bullet_area <= shootedPosition[0]))
                                {
                                    //если стрелять вверх
                                    if (((t1[1] + bullet_area >= shootedPosition[1]) && (t2[1] - bullet_area <= shootedPosition[1]) && shootingDirection[1]== -1)
                                        //если стрелять вниз
                                        || ((t1[1] - bullet_area <= shootedPosition[1]) && (t2[1] + bullet_area >= shootedPosition[1]) && shootingDirection[1] == 1))
                                    {
                                        shootedPlayer.Hit(flyingBullet);//добавить систему попадания в ближайшего, если 2+ игроков
                                        break;
                                    }

                                }
                            }
                            //если стреляю вправо или влево
                            if (t1[1] == t2[1])
                            {
                                //проверка по ширине траектории
                                if ((t1[1] + bullet_area >= shootedPosition[1]) && (t1[1] - bullet_area <= shootedPosition[1]))
                                {
                                    //если стрелять влево
                                    if (((t1[0] + bullet_area >= shootedPosition[0]) && (t2[0] - bullet_area <= shootedPosition[0]) && shootingDirection[0] == -1)
                                        //если стрелять вправо
                                        || ((t1[0] - bullet_area <= shootedPosition[0]) && (t2[0] + bullet_area >= shootedPosition[0]) && shootingDirection[0] == 1))
                                    {
                                        shootedPlayer.Hit(flyingBullet);//добавить систему попадания в ближайшего, если 2+ игроков
                                        break;
                                    }

                                }
                            }
                        }

                    }
                    if (move)
                        actualPlayer1.Move(x, y);
                    if (reload)
                        actualPlayer1.TankReload();
                }
                else
                {
                    var actualPlayer1 = (TankController_AI)actualPlayer;
                    actualPlayer1.player_x = players[1].TankLocation()[0];
                    actualPlayer1.player_y = players[1].TankLocation()[1];
                    actualPlayer1.player_dirx = players[1].TankDirection()[0];
                    actualPlayer1.player_diry = players[1].TankDirection()[1];
                    actualPlayer1.TakeTurn();
                    if (!(actualPlayer1.flying_bullet is EmptyBullet))
                    {
                        IBullet flyingBullet= actualPlayer1.flying_bullet;
                        int[] t1 = actualPlayer1.t1;//начало отрезка стрельбы
                        int[] t2 = actualPlayer1.t2;
                        foreach (var shootedPlayer in players)
                        {

                            if (actualPlayer == shootedPlayer) continue;

                            int[] shootedPosition = shootedPlayer.TankLocation();
                            int[] shootingDirection = actualPlayer.TankDirection();
                            //если стреляю вверх или вниз
                            if (t1[0] == t2[0])//всё правильно, не трогай
                            {
                                //проверка по ширине траектории
                                if ((t1[0] + bullet_area >= shootedPosition[0]) && (t1[0] - bullet_area <= shootedPosition[0]))
                                {
                                    //если стрелять вверх
                                    if (((t1[1] + bullet_area >= shootedPosition[1]) && (t2[1] - bullet_area <= shootedPosition[1]) && shootingDirection[1] == -1)
                                        //если стрелять вниз
                                        || ((t1[1] - bullet_area <= shootedPosition[1]) && (t2[1] + bullet_area >= shootedPosition[1]) && shootingDirection[1] == 1))
                                    {
                                        shootedPlayer.Hit(flyingBullet);//добавить систему попадания в ближайшего, если 2+ игроков
                                        break;
                                    }

                                }
                            }
                            //если стреляю вправо или влево
                            if (t1[1] == t2[1])
                            {
                                //проверка по ширине траектории
                                if ((t1[1] + bullet_area >= shootedPosition[1]) && (t1[1] - bullet_area <= shootedPosition[1]))
                                {
                                    //если стрелять влево
                                    if (((t1[0] + bullet_area >= shootedPosition[0]) && (t2[0] - bullet_area <= shootedPosition[0]) && shootingDirection[0] == -1)
                                        //если стрелять вправо
                                        || ((t1[0] - bullet_area <= shootedPosition[0]) && (t2[0] + bullet_area >= shootedPosition[0]) && shootingDirection[0] == 1))
                                    {
                                        shootedPlayer.Hit(flyingBullet);//добавить систему попадания в ближайшего, если 2+ игроков
                                        break;
                                    }

                                }
                            }
                        }
                    }
                }
                    
                

            }
        }
    }
}
