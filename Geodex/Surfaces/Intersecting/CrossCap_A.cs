using System;

namespace Geodex.Surfaces.Intersecting
{
    public class CrossCap_A : Field
    {

        #region members

        #endregion

        #region constructors

        public CrossCap_A() : base()
        {

        }

        public CrossCap_A(UV uv) : base()
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

            p.X = Math.Sin(i) * Math.Sin(2 * j);
            p.Y = Math.Sin(2 * i) * Math.Pow(Math.Sin(j), 2);
            p.Z = Math.Cos(2 * i) * Math.Pow(Math.Sin(j), 2);

        }

        #endregion

    }
}