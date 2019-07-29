using System;

namespace Geodex.Surfaces.Loop
{
    public class Pseudosphere : Field
    {

        #region members

        #endregion

        #region constructors

        public Pseudosphere() : base()
        {

        }

        public Pseudosphere(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = V * Math.PI;
            double j = 1 / Math.Cosh(U);

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = U - Math.Tanh(U);

        }

        #endregion

    }
}