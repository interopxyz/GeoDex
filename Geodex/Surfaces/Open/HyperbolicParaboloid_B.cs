using System;

namespace Geodex.Surfaces.Open
{
    public class HyperbolicParaboloid_B : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;

        #endregion

        #region constructors

        public HyperbolicParaboloid_B() : base()
        {

        }

        public HyperbolicParaboloid_B(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public HyperbolicParaboloid_B(UV uv, double a, double b, double c) : base()
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

            p.X = A * U;
            p.Y = B * V;
            p.Z = C * (Math.Pow(U, 2) - Math.Pow(V, 2));

        }

        #endregion

    }
}