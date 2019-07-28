using System;

namespace Geodex.Curves.Closed
{
    public class Rhodonea : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Rhodonea() : base()
        {

        }
        public Rhodonea(double a) : base()
        {
            this.A = a;
        }

        public Rhodonea(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = Math.Sin(A * s);

            p.X = i*Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}