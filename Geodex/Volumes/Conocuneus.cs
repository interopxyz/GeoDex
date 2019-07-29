using System;

namespace Geodex.Volumes
{
    public class Conocuneus : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;
        public double C = 0.25;
        public double D = 0.5;

        #endregion

        #region constructors

        public Conocuneus() : base()
        {

        }

        public Conocuneus(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Conocuneus(UV uv, double a, double b, double c, double d) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            double k = A - C * Math.Cos(i) * Math.Cos(j);

            p.X = (D * (C - A * Math.Cos(i) * Math.Cos(j)) + Math.Pow(B, 2) * Math.Cos(i)) / k;
            p.Y = (B * Math.Sin(i) * (A - D * Math.Cos(j))) / k;
            p.Z = (B * Math.Sin(j) * (C * Math.Cos(i) - D)) / k;

        }

        #endregion

    }
}