using System;

namespace Geodex.Surfaces.Open
{
    public class HelicoidMinimal : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public HelicoidMinimal() : base()
        {

        }

        public HelicoidMinimal(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public HelicoidMinimal(UV uv, double a) : base()
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
            double j = V * Math.PI;
            double k = A * Math.PI;

            p.X = Math.Pow(Math.E, i) * Math.Cos(j - k) / 2 + Math.Pow(Math.E, -i) * Math.Cos(j + k) / 2;
            p.Y = Math.Pow(Math.E, i) * Math.Sin(j - k) / 2 + Math.Pow(Math.E, -i) * Math.Sin(j + k) / 2;
            p.Z = Math.Cos(k) * i + Math.Sin(k) * j;

        }

        #endregion

    }
}
