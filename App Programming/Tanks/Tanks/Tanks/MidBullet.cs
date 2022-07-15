using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class MidBullet : IBullet
    {
        public int range => 150;
        public int damage => 15;
    }
}
