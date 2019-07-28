using System;

namespace Geodex.Surfaces
{
    public class Enneper_A : Field
    {

        public Enneper_A() : base()
        {

        }

        public Enneper_A(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            p.X = U - (Math.Pow(U, 3) / 3) + U * Math.Pow(V, 2);
            p.Y = -V - Math.Pow(U, 2) * V + (Math.Pow(V, 3) / 3);
            p.Z = Math.Pow(U, 2) - Math.Pow(V, 2);
        }
    }
}
