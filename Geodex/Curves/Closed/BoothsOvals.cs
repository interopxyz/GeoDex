using System;

namespace Geodex.Curves.Closed
{
    public class BoothsOvals : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public BoothsOvals() : base()
        {

        }

        public BoothsOvals(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public BoothsOvals(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = (Math.Pow(B, 2) * Math.Pow(Math.Cos(s), 2) + Math.Pow(A, 2) * Math.Pow(Math.Sin(s), 2));

            p.X = B * ((A * B * Math.Cos(s)) / i);
            p.Y = A * ((A * B * Math.Sin(s)) / i);

        }
    }
}