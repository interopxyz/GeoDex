using System;

namespace Geodex.Surfaces
{
    public class Cartan : Field
    {

        public Cartan() : base()
        {

        }

        public Cartan(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = i*Math.Pow(Math.Cos(j),3);

        }
    }
}