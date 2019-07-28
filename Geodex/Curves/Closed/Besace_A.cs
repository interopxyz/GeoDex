using System;

namespace Geodex.Curves.Closed
{
    public class Besace_A : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Besace_A() : base()
        {

        }

        public Besace_A(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Besace_A(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;


            p.X = A * Math.Sin(s);
            p.Y = Math.Cos(2 * s + B) * (A / 2) - Math.Cos(B) * (A / 2);

        }
    }
}
