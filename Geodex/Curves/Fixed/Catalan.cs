using System;

namespace Geodex.Curves.Fixed
{
    public class Catalan : Curve
    {
        public double A = 1.0;

        public Catalan() : base()
        {

        }

        public Catalan(double a) : base()
        {
            this.A = a;
        }

        public Catalan(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = A / (1 - Math.Pow(s, 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
