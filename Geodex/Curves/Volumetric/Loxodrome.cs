using System;

namespace Geodex.Curves.Volumetric
{
    public class Loxodrome : Curve
    {

        public double A = 3.0;

        public Loxodrome() : base()
        {

        }

        public Loxodrome(double a) : base()
        {
            this.A = a;
        }

        public Loxodrome(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = s / A;

            p.X = Math.Cos(s) / Math.Cosh(i);
            p.Y = Math.Sin(s) / Math.Cosh(i);
            p.Z = Math.Tanh(i);

        }
    }
}
