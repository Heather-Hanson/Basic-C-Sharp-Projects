using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway // Classes can call mulitiple interfaces. No need to state it as public because they are always public.
    {
        void WalkAway(Player player);
    }
}

// naming convention for naming interfaces is typically to start with an uppercase "I".