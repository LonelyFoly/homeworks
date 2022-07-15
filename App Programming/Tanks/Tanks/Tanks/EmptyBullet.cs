using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class EmptyBullet : IBullet
    {
        public int range => 0;
        public int damage => 0;
    }
}


