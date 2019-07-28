using System;

namespace Geodex.Curves.Closed
{
    public class Asteroid : Curve
    {

        public Asteroid() : base()
        {

        }

        public Asteroid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Pow(Math.Cos(s),3);
            p.Y = Math.Pow(Math.Sin(s),3);

        }
    }
}
