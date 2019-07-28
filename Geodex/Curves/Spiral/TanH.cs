using System;

namespace Geodex.Curves.Spiral
{
    public class TanH : Curve
    {
        public double A = 1;
        public TanH() : base()
        {

        }

        public TanH(double a) : base()
        {
            this.A = a;
        }

        public TanH(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = (Math.Cos(A * s) + Math.Cosh(s));

            p.X = Math.Sinh(s) / u;
            p.Y = Math.Sin(A * s) / u;
        }
    }
}
