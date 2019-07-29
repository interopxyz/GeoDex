using System;

namespace Geodex.Volumes
{
    public class Sphere : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Sphere() : base()
        {

        }

        public Sphere(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Sphere(UV uv, double a) : base()
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

            p.X = A * Math.Cos(i) * Math.Sin(j);
            p.Y = A * Math.Sin(i) * Math.Sin(j);
            p.Z = A * Math.Cos(j);

        }

        #endregion

    }
}