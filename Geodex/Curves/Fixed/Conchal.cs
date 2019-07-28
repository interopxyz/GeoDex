using System;

namespace Geodex.Curves.Fixed
{
    public class Conchal : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Conchal() : base()
        {

        }
        public Conchal(double a, double b) : base()
        {
            A = a;
            B = b;
        }

        public Conchal(double t, double a, double b) : base()
        {
            A = a;
            B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = s;
            p.Y = (Math.Sqrt((Math.Pow(B, 2) + Math.Pow(A, 2) - Math.Pow(s, 2)) * (Math.Pow(B, 2) - Math.Pow(A, 2) + Math.Pow(s, 2))) / (s + A));

        }
    }
}
