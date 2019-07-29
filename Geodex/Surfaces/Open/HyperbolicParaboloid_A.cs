using System;

namespace Geodex.Surfaces.Open
{
    public class HyperbolicParaboloid_A : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;

        #endregion

        #region constructors

        public HyperbolicParaboloid_A() : base()
        {

        }

        public HyperbolicParaboloid_A(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public HyperbolicParaboloid_A(UV uv, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = (A / 2) * (U + V);
            p.Y = (B / 2) * (U - V);
            p.Z = C * U * V;

        }

        #endregion

    }
}