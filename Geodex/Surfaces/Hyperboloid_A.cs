using System;

namespace Geodex.Surfaces
{
    public class Hyperboloid_A : Field
    {
        public double A = 1.0;
        public double C = 1.0;

        public Hyperboloid_A() : base()
        {

        }

        public Hyperboloid_A(double a, double c) : base()
        {
            this.A = a;
            this.C = c;
        }

        public Hyperboloid_A(UV uv, double a, double c) : base()
        {
            this.A = a;
            this.C = c;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = A * Math.Cosh(V);

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = C * Math.Sinh(V);

        }
    }
}