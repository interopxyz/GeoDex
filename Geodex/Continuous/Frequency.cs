using System;

namespace Geodex.Curves.Continous
{
    public class Frequency : Curve
    {
        public double Diameter = 1.0;
        public double Spread = 1.0;

        public Frequency() : base()
        {

        }

        public Frequency(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            p.X = t;
            p.Y = Math.Sqrt((2 * Math.PI) * Math.Exp(-Math.Pow(t, 2) / 2));

        }
    }
}

