using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Roman_B : Field
    {

        #region members

        #endregion

        #region constructors

        public Roman_B() : base()
        {

        }

        public Roman_B(UV uv) : base()
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

            p.X = Math.Cos(i) * Math.Cos(j) * Math.Sin(j);
            p.Y = Math.Sin(i) * Math.Cos(j) * Math.Sin(j);
            p.Z = Math.Cos(i) * Math.Sin(i) * Math.Cos(j);

        }

        #endregion

    }
}