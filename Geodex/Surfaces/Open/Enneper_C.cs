using System;

namespace Geodex.Surfaces.Open
{
    public class Enneper_C : Field
    {

        #region members

        public double A = 3.0;

        #endregion

        #region constructors

        public Enneper_C() : base()
        {

        }

        public Enneper_C(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Enneper_C(UV uv, double a) : base()
        {
            this.A = a;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = V * Math.PI;

            p.X = U * Math.Cos(i) - Math.Pow(U, (2 * A - 1)) * Math.Cos((2 * A - 1) * i) / (2 * A - 1);
            p.Y = U * Math.Sin(i) + Math.Pow(U, (2 * A - 1)) * Math.Sin((2 * A - 1) * i) / (2 * A - 1);
            p.Z = 2 * Math.Pow(U, A) * Math.Cos(A * i) / A;

        }

        #endregion

    }
}
