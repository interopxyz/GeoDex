using System;

namespace Geodex.Surfaces.Open
{
    public class Shell : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;
        public double D = 1.0;
        public double E = 1.0;

        #endregion

        #region constructors

        public Shell() : base()
        {

        }
        public Shell(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Shell(UV uv, double a, double b, double c, double d, double e) : base()
        {
            this.A = a;
            this.B = a;
            this.C = a;
            this.D = a;
            this.E = a;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            double k = (A + B * Math.Cos(j)) * Math.Pow(E, C * i);

            p.X = k * Math.Cos(i);
            p.Y = k * Math.Sin(i);
            p.Z = (D * A + B * Math.Sin(j)) * Math.Pow(E, C * i);

        }

        #endregion

    }
}
