using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Cartan : Field
    {

        #region members

        #endregion

        #region constructors

        public Cartan() : base()
        {

        }

        public Cartan(UV uv) : base()
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

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = i * Math.Pow(Math.Cos(j), 3);

        }

        #endregion

    }
}