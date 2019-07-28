using System;

namespace Geodex.Curves.Spatial
{
    public class Baseball : Curve
    {
        public double A = 2.0;
        public double B = 1.0;

        public Baseball() : base()
        {

        }

        public Baseball(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Baseball(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Cos(s) - A * Math.Cos(B * s);
            p.Y = Math.Sin(s) - A * Math.Sin(B * s);
            p.Z = (A * B) * Math.Cos(2 * s);

        }
    }
}
