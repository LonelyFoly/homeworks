using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class LongBullet : IBullet
    {
        public int range => 300;
        public int damage => 9;
    }
}
