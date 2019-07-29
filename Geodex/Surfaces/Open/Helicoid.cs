using System;

namespace Geodex.Surfaces.Open
{
    public class Helicoid : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Helicoid() : base()
        {

        }

        public Helicoid(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Helicoid(UV uv, double a) : base()
        {
            this.A = a;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = V * Math.PI * 2;

            p.X = U * Math.Cos(i);
            p.Y = U * Math.Sin(i);
            p.Z = V * A;

        }

        #endregion

    }
}
