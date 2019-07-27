using System;

namespace Geodex.Curves.Periodic
{
    public class Plateau : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Plateau() : base()
        {

        }
        public Plateau(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Plateau(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Sin((A + B) * s) / Math.Sin((A - B) * s);
            p.Y = 2 * Math.Sin(A * s) * Math.Sin(B * s) / Math.Sin((A - B) * s);

        }
    }
}
