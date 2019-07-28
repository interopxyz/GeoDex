using System;

namespace Geodex.Surfaces
{
    public class Roman_A : Field
    {

        public Roman_A() : base()
        {

        }

        public Roman_A(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = (Math.Sin(2 * i) * Math.Pow(Math.Sin(j), 2));
            p.Y = (Math.Sin(i) * Math.Cos(2 * j));
            p.Z = (Math.Cos(i) * Math.Sin(2 * j));

        }
    }
}