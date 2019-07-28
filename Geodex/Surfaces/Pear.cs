using System;

namespace Geodex.Surfaces
{
    public class Pear : Field
    {
        public double A = 1.0;
        public double B = 1.0;

        public Pear() : base()
        {

        }

        public Pear(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Pear(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = (A / 2) * B * Math.Sin(2 * i) * Math.Cos(j);
            p.Y = (A / 2) * B * Math.Sin(2 * i) * Math.Sin(j);
            p.Z = B * Math.Sin(i);
        }
    }
}

