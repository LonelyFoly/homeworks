using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    struct LightTankBody : ITankBody
    {
        public int hardness => 1;
        public double weight => 0.5;
    }
}
