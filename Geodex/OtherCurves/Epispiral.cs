using System;

namespace Geodex.Curves.Other
{
    public class Epispiral : Curve
    {
        public double A = 1.0;

        public Epispiral() : base()
        {

        }
        public Epispiral(double a) : base()
        {
            A = a;
        }

        public Epispiral(double t, double a) : base()
        {
            A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double i = 1 / Math.Cos(A * s);

            p.X = i * Math.Cos(s);
    p.Y = i * Math.Sin(s);

        }
    }
}
