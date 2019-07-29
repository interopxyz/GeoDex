using System;

namespace Geodex.Surfaces.Open
{
    public class Coil : Field
    {

        #region members

        public double A = 2.0;
        public double B = 1.0;
        public double C = 1.125;

        #endregion

        #region constructors

        public Coil() : base()
        {

        }

        public Coil(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Coil(UV uv, double a, double b, double c) : base()
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

            double i = U * Math.PI;
            double j = V * Math.PI;

            double k = ((B * C) / Math.Sqrt(Math.Pow(A, 2) * Math.Pow(C, 2)));

            p.X = (A + B * Math.Cos(j)) * Math.Cos(i) + k * Math.Sin(i) * Math.Sin(j);
            p.Y = (A + B * Math.Cos(j)) * Math.Sin(i) - k * Math.Cos(i) * Math.Sin(j);
            p.Z = C * U + ((B * A) / Math.Sqrt(Math.Pow(A, 2) * Math.Pow(C, 2))) * Math.Sin(j);

        }

        #endregion

    }
}