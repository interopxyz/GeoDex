using System;

namespace Geodex.Curves.Closed
{
    public class CyclicHarmonic : Curve
    {
        public double A = 1;
        public double B = 2;
        public double C = 2;
        public CyclicHarmonic() : base()
        {

        }

        public CyclicHarmonic(double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public CyclicHarmonic(double t, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = 1 + Math.E * A * Math.Cos(B * s);

            p.X = i * Math.Cos(s * C);
            p.Y = i * Math.Sin(s * C);
        }
    }
}
