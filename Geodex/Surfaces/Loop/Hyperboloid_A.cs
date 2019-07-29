using System;

namespace Geodex.Surfaces.Loop
{
    public class Hyperboloid_A : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Hyperboloid_A() : base()
        {

        }

        public Hyperboloid_A(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Hyperboloid_A(UV uv, double a, double b) : base()
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
            double j = A * Math.Cosh(V);

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = B * Math.Sinh(V);

        }

        #endregion

    }
}