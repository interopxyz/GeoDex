using System;

namespace Geodex.Surfaces.Loop
{
    public class Gabriels : Field
    {

        #region members

        #endregion

        #region constructors

        public Gabriels() : base()
        {

        }

        public Gabriels(UV uv) : base()
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

            p.X = Math.Cos(j) / i;
            p.Y = Math.Sin(j) / i;
            p.Z = i;

        }

        #endregion

    }
}