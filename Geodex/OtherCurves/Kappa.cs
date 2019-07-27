using System;

namespace Geodex.Curves.Other
{
    public class Kappa : Curve
    {

        public Kappa() : base()
        {

        }

        public Kappa(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = Math.Sin(s);

            p.X = i;
            p.Y = i * Math.Tan(s);
        }
    }
}
