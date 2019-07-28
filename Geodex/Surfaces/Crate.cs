using System;

namespace Geodex.Surfaces
{
    public class Crate : Field
    {
        public double A = 2.0;
        public double B = 1.0;

        public Crate() : base()
        {

        }

        public Crate(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Crate(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = U;
            p.Y = V;
            p.Z = A *( Math.Sin(i/B) +  Math.Sin(j/B));
        }
    }
}
