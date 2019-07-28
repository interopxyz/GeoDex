using System;

namespace Geodex.Surfaces
{
    public class Roman_B : Field
    {

        public Roman_B() : base()
        {

        }

        public Roman_B(UV uv) : base()
        {
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = Math.Cos(i) * Math.Cos(j) * Math.Sin(j);
            p.Y = Math.Sin(i) * Math.Cos(j) * Math.Sin(j);
            p.Z = Math.Cos(i) * Math.Sin(i) * Math.Cos(j);


        }
    }
}