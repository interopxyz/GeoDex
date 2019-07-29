using System;

namespace Geodex.Surfaces.Loop
{
    public class Mobius : Field
    {

        #region members

        public double A = 2.0;

        #endregion

        #region constructors

        public Mobius() : base()
        {

        }

        public Mobius(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Mobius(UV uv, double a) : base()
        {
            this.A = a;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;

            p.X = (Math.Cos(i) + V * Math.Cos(i / A) * Math.Cos(i));
            p.Y = (Math.Sin(i) + V * Math.Cos(i / A) * Math.Sin(i));
            p.Z = V * Math.Sin(i / A);

        }

        #endregion

    }
}