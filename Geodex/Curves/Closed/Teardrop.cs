using System;

namespace Geodex.Curves.Closed
{
    public class Teardrop : Curve
    {
        public double A = 1;

        public Teardrop() : base()
        {

        }

        public Teardrop(double a) : base()
        {
            this.A = a;
        }

        public Teardrop(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Cos(s);
            p.Y = Math.Sin(s) * Math.Pow(Math.Sin(s / 2), A);
        }
    }
}
