using System;

namespace Geodex.Surface
{
    public class Pseudosphere : Field
    {

        public Pseudosphere() : base()
        {

        }

        public Pseudosphere(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = V * Math.PI;
            double j = 1 / Math.Cosh(U);

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = U-Math.Tanh(U);

        }
    }
}