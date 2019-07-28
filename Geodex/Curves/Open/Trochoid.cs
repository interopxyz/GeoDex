using System;

namespace Geodex.Curves.Open
{
    public class Trochoid:Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Trochoid() : base()
        {

        }
        public Trochoid(double a, double b) : base()
        {
            A = a;
            B = b;
        }

        public Trochoid(double t, double a, double b) : base()
        {
            A = a;
            B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = A * s - B * Math.Sin(s);
            p.Y = A - B * Math.Cos(s);


        }
    }
}
