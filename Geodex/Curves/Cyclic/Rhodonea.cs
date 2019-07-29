using System;

namespace Geodex.Curves.Cyclic
{
    public class Rhodonea : Curve
    {

        #region members

        public double A = 3.5;

        #endregion

        #region constructors

        public Rhodonea() : base()
        {

        }

        public Rhodonea(double t) : base()
        {
            this.T = t;
        }

        public Rhodonea(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = Math.Sin(A * s);

            p.X = i*Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}