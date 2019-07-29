using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Roman_A : Field
    {

        #region members

        #endregion

        #region constructors

        public Roman_A() : base()
        {

        }

        public Roman_A(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = (Math.Sin(2 * i) * Math.Pow(Math.Sin(j), 2));
            p.Y = (Math.Sin(i) * Math.Cos(2 * j));
            p.Z = (Math.Cos(i) * Math.Sin(2 * j));

        }

        #endregion

    }
}