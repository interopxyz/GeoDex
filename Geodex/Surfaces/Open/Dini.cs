using System;

namespace Geodex.Surfaces.Open
{
    public class Dini : Field
    {

        #region members

        public double A = 0.2;

        #endregion

        #region constructors

        public Dini() : base()
        {

        }

        public Dini(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Dini(UV uv, double a) : base()
        {
            this.A = a;

            this.Parameter = uv;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V;


            p.X = Math.Cos(i) * Math.Sin(j);
            p.Y = Math.Sin(i) * Math.Sin(j);
            p.Z = (Math.Cos(j) + Math.Log(Math.Tan(j / 2))) + A * i;

        }

        #endregion

    }
}