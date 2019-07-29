using System;

namespace Geodex.Surfaces.Intersecting
{
    public class CrossCap_B : Field
    {

        #region members

        #endregion

        #region constructors

        public CrossCap_B() : base()
        {

        }

        public CrossCap_B(UV uv) : base()
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

            p.X = Math.Cos(i) * Math.Sin(2 * j);
            p.Y = Math.Sin(i) * Math.Sin(2 * j);
            p.Z = Math.Pow(Math.Cos(j), 2) - Math.Pow(Math.Cos(i), 2) * Math.Pow(Math.Sin(j), 2);

        }

        #endregion

    }
}