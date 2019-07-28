using System;

namespace Geodex.Surfaces
{
    public class Monkey_B : Field
    {
        public double A = 1.0;

        public Monkey_B() : base()
        {

        }
        public Monkey_B(double a) : base()
        {
            A = a;
        }

        public Monkey_B(UV uv, double a) : base()
        {
            A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = Math.Pow(i, 3) * Math.Cos(A * j);
        }
    }
}
