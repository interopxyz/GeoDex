using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Pear : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Pear() : base()
        {

        }

        public Pear(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Pear(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = (A / 2) * B * Math.Sin(2 * i) * Math.Sin(j);
            p.Y = (A / 2) * B * Math.Sin(2 * i) * Math.Cos(j);
            p.Z = B * Math.Sin(i);

        }

        #endregion

    }
}

