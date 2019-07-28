using System;

namespace Geodex.Surfaces
{
    public class Mobius : Field
    {
        public double A = 2.0;

        public Mobius() : base()
        {

        }

        public Mobius(double a) : base()
        {
            this.A = a;
        }

        public Mobius(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;

            p.X = (Math.Cos(i) + V * Math.Cos(i / A) * Math.Cos(i));
            p.Y = (Math.Sin(i) + V * Math.Cos(i / A) * Math.Sin(i));
            p.Z = V * Math.Sin(i / A);

        }
    }
}