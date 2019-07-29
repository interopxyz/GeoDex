using System;

namespace Geodex.Curves.Periodic
{
    public class Cosine : Curve
    {

        #region members

        #endregion

        #region constructors

        public Cosine() : base()
        {

        }

        public Cosine(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = t;
            p.Y =  Math.Cos(t * Math.PI);

        }

        #endregion

    }
}
