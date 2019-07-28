using System;

namespace Geodex.Surfaces
{
    public class Conoid : Field
    {
        public double A = 1.0;
        public double B = 1.0;

        public Conoid() : base()
        {

        }

        public Conoid(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Conoid(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
    p.Z = A * Math.Cos(B * j);
        }
    }
}

