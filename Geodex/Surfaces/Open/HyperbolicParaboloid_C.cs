using System;

namespace Geodex.Surfaces.Open
{
    public class HyperbolicParaboloid_C : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public HyperbolicParaboloid_C() : base()
        {

        }

        public HyperbolicParaboloid_C(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public HyperbolicParaboloid_C(UV uv, double a) : base()
        {
            this.A = a;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = U * Math.Cos(V);
            p.Y = A * Math.Tan(V);
            p.Z = U * Math.Sin(V);

        }

        #endregion

    }
}