using System;
using System.Collections.Generic;
using System.Text;

namespace Chemistry.Core
{
    public class Nucleus
    {
        

        public int NumberOfProtons { get; private set; } 
        public int NumberOfNeutrons { get; private set; }

        public Nucleus(int NumberOfProtons, int NumberOfNeutrons)
        {
            this.NumberOfProtons = NumberOfProtons;
            this.NumberOfNeutrons = NumberOfNeutrons;
        }
    }
}
