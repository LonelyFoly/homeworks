using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class ShortBullet: IBullet
    {
        public int range => 50;
        public int damage => 30;
    }
}
