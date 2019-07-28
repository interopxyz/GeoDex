using System;

namespace Geodex.Surfaces
{
    public class Helicoid : Field
    {

        public double A = 1.0;

        public Helicoid() : base()
        {

        }

        public Helicoid(double a) : base()
        {
            this.A = a;
        }

        public Helicoid(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = V * Math.PI * 2;

            p.X = U * Math.Cos(i);
            p.Y = U * Math.Sin(i);
            p.Z = V * A;
        }
    }
}
