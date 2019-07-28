using System;

namespace Geodex.Curves.Open
{
    public class Cissoid : Curve
    {
        double A = 1.0;

        public Cissoid() : base()
        {

        }

        public Cissoid(double a) : base()
        {
            this.A = a;
        }

        public Cissoid(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t*Math.PI;

            p.X = Math.Pow(s * Math.Cos(A / 2) - Math.Sin(A / 2), 2) / (1 + Math.Pow(s, 2));
            p.Y = s * p.X;
        }
    }
}
