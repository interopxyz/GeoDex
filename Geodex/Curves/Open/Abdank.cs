using System;

namespace Geodex.Curves.Open
{
    public class Abdank : Curve
    {
        public double A = 1.0;

        public Abdank() : base()
        {

        }
        public Abdank(double a) : base()
        {
            this.A = a;
        }

        public Abdank(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = A * Math.Sin(s);
            p.Y = (Math.Pow(A, 2) / 2) * (s + Math.Sin(s) * Math.Cos(s));

        }
    }
}
