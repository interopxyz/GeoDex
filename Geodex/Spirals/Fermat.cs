using System;

namespace Geodex.Curves.Spiral
{
    public class Fermat : Curve
    {
        public double A = 1;
        public Fermat() : base()
        {

        }

        public Fermat(double a) : base()
        {
            this.A = a;
        }

        public Fermat(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = Math.Pow(s, 1 / A);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}
