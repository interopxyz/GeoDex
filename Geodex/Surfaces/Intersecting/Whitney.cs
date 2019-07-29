using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Whitney : Field
    {

        #region members

        #endregion

        #region constructors

        public Whitney() : base()
        {

        }

        public Whitney(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = U * V;
            p.Y = U;
            p.Z = Math.Pow(V, 2);

        }

        #endregion

    }
}