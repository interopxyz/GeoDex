using System;

namespace Geodex.Surfaces.Loop
{
    public class Hyperboloid_B : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Hyperboloid_B() : base()
        {

        }

        public Hyperboloid_B(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Hyperboloid_B(UV uv, double a, double b) : base()
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

            double i = Math.PI * V;
            double j = A * Math.Sqrt(1 + Math.Pow(U, 2));

            p.X = j * Math.Cos(i);
            p.Y = j * Math.Sin(i);
            p.Z = B * U;

        }

        #endregion

    }
}