using System;

namespace Geodex.Surface
{
    public class Dini : Field
    {
        public double A = 1.0;

        public Dini() : base()
        {

        }

        public Dini(double a) : base()
        {
            this.A = a;
        }

        public Dini(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = A * Math.Cosh(V / A);

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = V;
        }
    }
}