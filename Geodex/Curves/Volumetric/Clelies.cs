using System;

namespace Geodex.Curves.Spatial
{
    public class Clelies : Curve
    {
        public double A = 2.0;
        public double B = 1.0;

        public Clelies() : base()
        {

        }

        public Clelies(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Clelies(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Sin(A*s) * Math.Cos(B*s);
            p.Y = Math.Sin(A*s) * Math.Sin(B*s);
            p.Z = Math.Cos(A * s);

        }
    }
}
