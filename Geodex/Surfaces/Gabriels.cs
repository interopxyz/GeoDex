using System;

namespace Geodex.Surfaces
{
    public class Gabriels : Field
    {

        public Gabriels() : base()
        {

        }

        public Gabriels(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = Math.Cos(j) / i;
            p.Y = Math.Sin(j) / i;
            p.Z = i;
        }
    }
}