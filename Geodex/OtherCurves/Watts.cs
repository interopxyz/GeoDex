using System;

namespace Geodex.Curves.Periodic
{
    public class Watts : Curve
    {

        public double A = 1;
        public double B = 1;
        public double C = 1;

        public Watts() : base()
        {

        }
        public Watts(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = Math.Sqrt(Math.Pow(B, 2) - Math.Pow(A * Math.Sin(s) + Math.Sqrt(Math.Pow(C, 2) - Math.Pow(A, 2) * Math.Pow(Math.Cos(s), 2)), 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);
        }
    }
}
