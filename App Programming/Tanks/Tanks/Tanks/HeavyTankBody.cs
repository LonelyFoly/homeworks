using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    struct HeavyTankBody: ITankBody
    {
        public int hardness => 3;
        public double weight => 1.5;
    }
}
