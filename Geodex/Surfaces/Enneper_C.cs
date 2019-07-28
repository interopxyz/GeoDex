using System;

namespace Geodex.Surfaces
{
    public class Enneper_C : Field
    {

        public double A = 3;

        public Enneper_C() : base()
        {

        }

        public Enneper_C(double a) : base()
        {
            this.A = a;
        }

        public Enneper_C(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = V * Math.PI;

            p.X = U * Math.Cos(i) - Math.Pow(U, (2 * A - 1)) * Math.Cos((2 * A - 1) * i) / (2 * A - 1);
            p.Y = U * Math.Sin(i) + Math.Pow(U, (2 * A - 1)) * Math.Sin((2 * A - 1) * i) / (2 * A - 1);
            p.Z = 2 * Math.Pow(U, A) * Math.Cos(A * i) / A;
                
        }
    }
}
