using System;

namespace Geodex.Curves.Other
{
    public class Cassini : Curve
    {
        double A = 1;

        public Cassini() : base()
        {

        }

        public Cassini(double a) : base()
        {
            this.A = a;
        }

        public Cassini(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = Math.Sqrt(Math.Cos(s * 2) + Math.Sqrt(Math.Pow((A), 4) - Math.Pow(Math.Sin(s * 2), 2)));
        
            p.X = i*Math.Cos(s);
            p.Y = i*Math.Sin(s);
        }
    }
}
