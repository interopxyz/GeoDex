using System;

namespace Geodex.Curves.Spatial
{
    public class Archytas : Curve
    {

        #region members

        #endregion

        #region constructors

        public Archytas() : base()
        {

        }

        public Archytas(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Pow(Math.Cos(s), 2);
            p.Y = Math.Cos(s) * Math.Sin(s);
            p.Z = t / Math.Abs(t) * Math.Sqrt((1 - Math.Cos(s)) * Math.Cos(s));

        }

        #endregion

    }
}
