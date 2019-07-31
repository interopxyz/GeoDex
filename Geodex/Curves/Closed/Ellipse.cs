using System;

namespace Geodex.Curves.Closed
{
    public class Ellipse : Curve
    {

        #region members

        public double A = 2.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Ellipse() : base()
        {

        }

        public Ellipse(double t) : base()
        {
            this.T = t;
        }

        public Ellipse(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = A * Math.Sin(t * Math.PI);
            p.Y = B * Math.Cos(t * Math.PI);

        }

        #endregion

    }
}
