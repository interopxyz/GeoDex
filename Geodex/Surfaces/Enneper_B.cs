using System;

namespace Geodex.Surfaces
{
    public class Enneper_B : Field
    {

        public Enneper_B() : base()
        {

        }

        public Enneper_B(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = V * Math.PI;

            p.X = U * Math.Cos(i) - Math.Pow(U, 3) / 3 * Math.Cos(3 * i);
            p.Y = -U / 3 * (3 * Math.Sin(i) + Math.Pow(U, 2) * Math.Sin(3 * i));
            p.Z = Math.Pow(U, 2) * Math.Cos(2 * i);
        }
    }
}
