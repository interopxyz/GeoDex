using System;

namespace Geodex.Curves.Other
{
    public class Nodal:Curve
    {

        #region members

        public double A = 2.5;

        #endregion

        #region constructors

        public Nodal() : base()
        {

        }

        public Nodal(double t) : base()
        {
            this.T = t;
        }

        public Nodal(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
            double i = Math.Tan(A * s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
