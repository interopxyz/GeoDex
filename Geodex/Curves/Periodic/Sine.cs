using System;

namespace Geodex.Curves.Periodic
{
    public class Sine : Curve
    {

        #region members

        #endregion

        #region constructors

        public Sine() : base()
        {
            
        }

        public Sine(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = t;
            p.Y = Math.Sin(t * Math.PI);

        }

        #endregion

    }
}
