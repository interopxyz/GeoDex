using System;

namespace Geodex.Surfaces.Open
{
    public class Monkey_A : Field
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Monkey_A() : base()
        {

        }
        public Monkey_A(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Monkey_A(UV uv, double a) : base()
        {
            this.A = a;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = Parameter.U;
            p.Y = Parameter.V;
            p.Z = A * (Math.Pow(Parameter.U, 3) - 3 * Parameter.U * Math.Pow(Parameter.V, 2));

        }

        #endregion

    }
}
