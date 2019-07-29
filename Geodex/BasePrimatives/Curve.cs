using System;

namespace Geodex
{
    public abstract class Curve
    {

        #region members

        protected double t = 0;
        protected Point p = new Point();

        #endregion

        #region constructor

        public Curve()
        {

        }

        #endregion

        #region properties

        public virtual double T
        {
            get { return t; }
            set
            {
                this.t = value;
                Evaluate();
            }
        }

        #endregion

        #region methods

        protected virtual void Evaluate()
        {
        }

        protected virtual void EvaluateCartesian()
        {
        }

        public virtual Point Location
        {
            get { return p; }
        }
        #endregion

    }
}
