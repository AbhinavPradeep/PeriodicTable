using System;
using System.Collections.Generic;
using System.Text;

namespace Chemistry.Core
{
    public class Proton
    {
        public Charge Charge { get;private set; }
        public int ChargeValue { get; private set; }
        public double Mass { get; private set; }
        public Proton()
        {
            this.Charge = Charge.Positive;
            this.ChargeValue = 1;
        }
    }
}
