using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    public interface IBullet
    {
        int range
        { get; }
        int damage 
            { get; }
        int bullet_area
        { get; }

    }
    struct EmptyBullet : IBullet
    {
        public int range  {get=>0;}
        public int damage { get => 0; }
        public int bullet_area { get => 0; }
    }
    struct LongBullet : IBullet
    {
        public int range { get => 300; }
        public int damage { get => 9; }
        public int bullet_area { get => 20; }//можно разные сделать для разных пуль
    }
    struct MidBullet : IBullet
    {
        public int range { get => 150; }
        public int damage { get => 15; }
        public int bullet_area { get => 20; }
    }
    struct ShortBullet : IBullet
    {
        public int range { get => 50; }
        public int damage { get => 30; }
        public int bullet_area { get => 20; }
    }
}
