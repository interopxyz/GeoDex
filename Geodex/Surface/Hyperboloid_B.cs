using System;

namespace Geodex.Surface
{
    public class Hyperboloid_B : Field
    {
        public double A = 1.0;
        public double C = 1.0;

        public Hyperboloid_B() : base()
        {

        }

        public Hyperboloid_B(double a, double c) : base()
        {
            this.A = a;
            this.C = c;
        }

        public Hyperboloid_B(UV uv, double a, double c) : base()
        {
            this.A = a;
            this.C = c;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = Math.PI * V;
            double j = A * Math.Sqrt(1 + Math.Pow(U, 2));

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = C * U;
        }
    }
}