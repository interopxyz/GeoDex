using System;

namespace Geodex.Curves.Closed
{
    public class Biquartic : Curve
    {
        public double A = 1.0;

        public Biquartic() : base()
        {

        }

        public Biquartic(double a) : base()
        {
            this.A = a;
        }

        public Biquartic(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Sin(A * s) * Math.Cos(s);
            p.Y = Math.Pow(Math.Sin(A * s) * Math.Sin(s),2);

        }
    }
}
