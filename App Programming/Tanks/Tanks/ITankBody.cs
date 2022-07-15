using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    interface ITankBody
    {
        int hardness
        { get;}
        double weight
        { get;}
    }
    struct LightTankBody : ITankBody
    {
        public int hardness { get => 1; }
        public double weight { get => 0.5; }
    }
    struct HeavyTankBody : ITankBody
    {
        public int hardness { get => 3; }
        public double weight { get => 1.5; }
    }
    struct MidTankBody : ITankBody
    {

        public int hardness { get => 2; }
        public double weight { get => 1; }
    }
}
