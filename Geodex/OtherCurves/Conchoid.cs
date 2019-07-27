using System;

namespace Geodex.Curves.Other
{
    public class Conchoid : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Conchoid() : base()
        {

        }
        public Conchoid(double a, double b) : base()
        {
            A = a;
            B = b;
        }

        public Conchoid(double t, double a, double b) : base()
        {
            A = a;
            B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double i = A + B * (1 / Math.Cos(s));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
