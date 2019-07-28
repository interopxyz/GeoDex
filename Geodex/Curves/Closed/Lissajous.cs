using System;

namespace Geodex.Curves.Closed
{
    public class Lissajous : Curve
    {
        public double A = 1;
        public double B = 2;
        public double Rotation = 0;
        public Lissajous() : base()
        {

        }

        public Lissajous(double a, double b, double rotation) : base()
        {
            this.A = a;
            this.B = b;
            this.Rotation = rotation;
        }

        public Lissajous(double t, double a, double b, double rotation) : base()
        {
            this.A = a;
            this.B = b;
            this.Rotation = rotation;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Sin(A * 2 * s + Rotation * Math.PI);
            p.Y = Math.Sin(B * 2 * s);
        }
    }
}
