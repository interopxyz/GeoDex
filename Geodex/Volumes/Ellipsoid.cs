using System;

namespace Geodex.Volumes
{
    public class Ellipsoid : Field
    {

        #region members

        public double A = 4.0;
        public double B = 2.0;
        public double C = 1.0;

        #endregion

        #region constructors


        public Ellipsoid() : base()
        {

        }

        public Ellipsoid(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Ellipsoid(UV uv, double a, double b, double c) : base()
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

            p.X = A * Math.Cos(i) * Math.Sin(j);
            p.Y = B * Math.Sin(i) * Math.Sin(j);
            p.Z = C * Math.Cos(j);

        }

        #endregion

    }
}