using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    interface IBullet
    {
        int range
        { get; }
        int damage 
            { get; }
    }
}
