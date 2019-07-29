using System;

namespace Geodex.Curves.Closed
{
    public class Folium : Curve
    {

        #region members

        public double A = 0.25;
        public double B = 1;

        #endregion

        #region constructors

        public Folium() : base()
        {

        }

        public Folium(double t) : base()
        {
            this.T = t;
        }

        public Folium(double t, double a, double b) : base()
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

            double i = -B*Math.Cos(s)+4*A*Math.Cos(s)*Math.Pow(Math.Sin(s),2);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
