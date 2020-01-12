using System;
using System.Collections.Generic;
using System.Text;

namespace Chemistry.Core
{
    public class Electron
    {
        public Charge Charge { get; private set; }

        public Electron()
        {
            this.Charge = Charge.Negative;
        }
    }
}
