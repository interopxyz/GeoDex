using System;

namespace Geodex.Curves.Closed
{
    public class Alain : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Alain() : base()
        {

        }

        public Alain(double t) : base()
        {
            this.T = t;
        }

        public Alain(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
             
            double i = Math.Sqrt(Math.Pow(A, 2) * Math.Pow(Math.Cos(s), 2) - Math.Pow(B, 2) * Math.Pow(Math.Sin(s), 2)) / Math.Cos(s * 2);
            
            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
