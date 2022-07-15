using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    public class Game
    {
        int area = 500;//размер поля = size x size
        public int AreaGet { get { return area; } }

        List<TankController> players = new List<TankController>() {new TankController_AI(400,400, Properties.Resources._1), new TankController_Player(0,0, Properties.Resources._2) };
        public bool CheckWin()
        {
            foreach (var actualPlayer in players)
            {
                if (!(actualPlayer.IsAlive))
                    return true;
                
            }
            return false;
        }
        
        public Point[] Draw ()
        {
            Tools.image1 = players[0].image;//AI
            Tools.image2 = players[1].image;//PLAYER
            Point[] a =new Point[2];
            for (int i = 0; i < 2; i++)
            {
                a[i] =players[i].Draw();
            }
            return a;
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
        public void ChangeBody(string item)
        {
            ((TankController_Player)players[1]).ChangeBody(item);
        }

        

        public void NextTurn(bool shoot, bool move, bool reload, int x, int y)
        {
            
            foreach (var actualPlayer in players)
            {
                if (actualPlayer is  TankController_Player)
                {
                    var actualPlayer1 = (TankController_Player)actualPlayer;
                    //actualPlayer1.InfoGetter();
                    actualPlayer1.TakeTurn(x, y, shoot, move, reload);
                    if (shoot)
                        foreach (var shootedPlayer in players)
                        {
                            if (actualPlayer == shootedPlayer) continue;
                            shootedPlayer.Hit();
                        }
                }
                else
                {
                    var actualPlayer1 = (TankController_AI)actualPlayer;

                    actualPlayer1.InfoGetter(players[1].TankLocation().X, players[1].TankLocation().Y,
                        players[1].TankDirection()[0], players[1].TankDirection()[1]);
                    actualPlayer1.TakeTurn();
                    if (actualPlayer1.IWantToShoot)
                        foreach (var shootedPlayer in players)
                        {
                            if (actualPlayer == shootedPlayer) continue;
                            shootedPlayer.Hit();
                        }
                   
                }
                    
                

            }
        }
    }
}
