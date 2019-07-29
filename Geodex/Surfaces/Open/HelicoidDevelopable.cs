using System;

namespace Geodex.Surfaces.Open
{
    public class HelicoidDevelopable : Field
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public HelicoidDevelopable() : base()
        {

        }

        public HelicoidDevelopable(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public HelicoidDevelopable(UV uv, double a, double b) : base()
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
            double j = V * Math.PI;

            p.X = A * (Math.Cos(i) - j * Math.Sin(i));
            p.Y = A * (Math.Sin(i) + j * Math.Cos(i));
            p.Z = B * (i + j);

        }

        #endregion

    }
}
