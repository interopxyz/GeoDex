using System;

namespace Geodex.Curves.Closed
{
    public class Ellipse : Curve
    {

        #region members

        public double Width = 2.0;
        public double Height = 1.0;

        #endregion

        #region constructors

        public Ellipse() : base()
        {

        }

        public Ellipse(double t) : base()
        {
            this.T = t;
        }

        public Ellipse(double t, double width, double height) : base()
        {
            this.Width = width;
            this.Height = height;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = Width * Math.Sin(t * Math.PI);
            p.Y = Height * Math.Cos(t * Math.PI);

        }

        #endregion

    }
}
