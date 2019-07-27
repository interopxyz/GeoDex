using System;

namespace Geodex.Surface
{
    public class Sine : Field
    {

        public Sine() : base()
        {

        }

        public Sine(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = Math.Sin(i);
            p.Y = Math.Sin(j);
            p.Z = Math.Sin(i+j);

        }
    }
}