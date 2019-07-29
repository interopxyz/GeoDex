using System;

namespace Geodex.Surfaces.Open
{
    public class Crate : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Crate() : base()
        {

        }

        public Crate(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Crate(UV uv, double a, double b) : base()
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

            p.X = U;
            p.Y = V;
            p.Z = A * (Math.Sin(i / B) + Math.Sin(j / B));

        }

        #endregion

    }
}
