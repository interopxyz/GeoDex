using System;

namespace Geodex.Curves.Open
{
    public class Catenary : Curve
    {

        #region members

        #endregion

        #region constructors

        public Catenary() : base()
        {

        }

        public Catenary(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {
        }

        #endregion


    }
}
