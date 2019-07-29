using System;

namespace Geodex.Surfaces.Intersecting
{
    public class BohemianDome : Field
    {

        #region members

        public double A = 2.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public BohemianDome() : base()
        {

        }

        public BohemianDome(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public BohemianDome(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = A * Math.Cos(i);
            p.Y = B * Math.Cos(j);
            p.Z = A * Math.Sin(i) + B * Math.Sin(j);

        }

        #endregion

    }
}
