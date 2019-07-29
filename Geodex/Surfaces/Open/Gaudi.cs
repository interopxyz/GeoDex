using System;

namespace Geodex.Surfaces.Open
{
    public class Gaudi : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Gaudi() : base()
        {

        }

        public Gaudi(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Gaudi(UV uv, double a, double b) : base()
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
            p.Z = B * (i * Math.Sin(j / A));

        }

        #endregion

    }
}