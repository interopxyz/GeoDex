using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Conoid : Field
    {

        #region members

        public double A = 1.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Conoid() : base()
        {

        }

        public Conoid(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Conoid(UV uv, double a, double b) : base()
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

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = A * Math.Cos(B * j);

        }

        #endregion

    }
}

