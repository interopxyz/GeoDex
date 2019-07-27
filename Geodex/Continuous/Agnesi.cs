using System;

namespace Geodex.Curves.Continous
{
    public class Agnesi : Curve
    {
        public double Diameter = 1.0;
        public double Spread = 1.0;

        public Agnesi() : base()
        {

        }
        public Agnesi(double diameter, double spread) : base()
        {
            Diameter = diameter;
            Spread = spread;
        }

        public Agnesi(double t, double diameter, double spread) : base()
        {
            Diameter = diameter;
            Spread = spread;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Spread;
            p.X = s;
            p.Y = (8.0 * Math.Pow(Diameter, 3.0)) / (Math.Pow(s, 2) + 4.0 * Math.Pow(Diameter, 2));
            
        }
    }
}
