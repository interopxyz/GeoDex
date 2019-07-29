using System;

namespace Geodex.Surfaces.Open
{
    public class Monkey_B : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Monkey_B() : base()
        {

        }
        public Monkey_B(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Monkey_B(UV uv, double a) : base()
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

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = Math.Pow(i, 3) * Math.Cos(A * j);

        }

        #endregion

    }
}
