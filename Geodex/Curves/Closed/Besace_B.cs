using System;

namespace Geodex.Curves.Closed
{
    public class Besace_B : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Besace_B() : base()
        {

        }

        public Besace_B(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Besace_B(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = A * Math.Cos(s) - B * Math.Sin(s);
            p.Y = (-1 * Math.Sin(s)) * p.X;

        }
    }
}
