using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    struct MidTankBody : ITankBody
    {

        public int hardness => 2;
        public double weight => 1;
    }
}
