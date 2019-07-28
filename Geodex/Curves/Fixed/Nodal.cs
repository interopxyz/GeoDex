using System;

namespace Geodex.Curves.Fixed
{
    public class Nodal:Curve
    {
        public double A = 1;

        public Nodal() : base()
        {

        }

        public Nodal(double a) : base()
        {
            this.A = a;
        }

        public Nodal(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double i = Math.Tan(A * s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);
        }
    }
}
