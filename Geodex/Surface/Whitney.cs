using System;

namespace Geodex.Surface
{
    public class Whitney : Field
    {

        public Whitney() : base()
        {

        }

        public Whitney(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            p.X = U * V;
            p.Y = U;
            p.Z = Math.Pow(V, 2);

        }
    }
}