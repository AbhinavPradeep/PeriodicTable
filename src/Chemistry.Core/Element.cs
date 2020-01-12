using System;

namespace Chemistry.Core
{
    public class Element
    {
        public string ElementName { get; private set; }
        public string Symbol { get; private set; }
        public int AtomicNumber { get; private set; }
        public double RelativeAtomicMass { get; private set; }

        public Nucleus Nucleus { get; private set; }
        
        

        public Element(string ElementName,
                       string Symbol,
                       int AtomicNumber,
                       double RelativeAtomicMass)
        {
            this.ElementName = ElementName;
            this.Symbol = Symbol;
            this.AtomicNumber = AtomicNumber;
            this.RelativeAtomicMass = RelativeAtomicMass;

            this.Nucleus = new Nucleus(this.AtomicNumber, (int)(this.RelativeAtomicMass - this.AtomicNumber));

        }



    }
}

    