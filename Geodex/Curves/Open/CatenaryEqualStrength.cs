using System;

namespace Geodex.Curves.Open
{
    public class CatenaryEqualStrength : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public CatenaryEqualStrength() : base()
        {

        }
        public CatenaryEqualStrength(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public CatenaryEqualStrength(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI*A;

            p.X = s;
            p.Y = (-1 * A) * Math.Log(Math.Cos(s / A));

        }
    }
}
