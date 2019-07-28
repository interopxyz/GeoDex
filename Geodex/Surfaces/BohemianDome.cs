using System;

namespace Geodex.Surfaces
{
    public class BohemianDome : Field
    {
        public double A = 2.0;
        public double B = 1.0;

        public BohemianDome() : base()
        {

        }

        public BohemianDome(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public BohemianDome(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = A * Math.Cos(i);
            p.Y = B * Math.Cos(j);
            p.Z = A * Math.Sin(i) + B * Math.Sin(j);
        }
    }
}
