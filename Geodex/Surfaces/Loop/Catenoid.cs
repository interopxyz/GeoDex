using System;

namespace Geodex.Surfaces.Loop
{
    public class Catenoid : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Catenoid() : base()
        {

        }

        public Catenoid(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Catenoid(UV uv, double a) : base()
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
            double j = A * Math.Cosh(V / A);

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = V;

        }

        #endregion

    }
}