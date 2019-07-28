using System;

namespace Geodex.Surfaces
{
    public class Gaudi : Field
    {
        public double A = 1.0;
        public double B = 1.0;

        public Gaudi() : base()
        {

        }

        public Gaudi(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Gaudi(UV uv, double a, double b) : base()
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
            p.Z = B*(i * Math.Sin(j / A));

        }
    }
}