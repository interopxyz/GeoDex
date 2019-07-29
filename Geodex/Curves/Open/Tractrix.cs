using System;

namespace Geodex.Curves.Open
{
    public class Tractrix : Curve
    {

        #region members

        #endregion

        #region constructors

        public Tractrix() : base()
        {

        }

        public Tractrix(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = s - Math.Tanh(s);
            p.Y = 1.0/Math.Cosh(s);

        }

        #endregion

    }
}
