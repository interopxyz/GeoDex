using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Sine : Field
    {

        #region members

        #endregion

        #region constructors

        public Sine() : base()
        {

        }

        public Sine(UV uv) : base()
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

            p.X = Math.Sin(i);
            p.Y = Math.Sin(j);
            p.Z = Math.Sin(i + j);

        }

        #endregion

    }
}