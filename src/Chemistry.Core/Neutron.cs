using System;
using System.Collections.Generic;
using System.Text;

namespace Chemistry.Core
{
    public class Neutron
    {
        public Charge Charge { get; private set; }

        public Neutron()
        {
            this.Charge = Charge.Neutral;
        }
    }
}
