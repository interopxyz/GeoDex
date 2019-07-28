using System;

namespace Geodex.Curves.Closed
{
    public class Kiss: Curve
    {
        public Kiss() : base()
        {

        }

        public Kiss(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            
            p.X = Math.Cos(s);
            p.Y = Math.Pow(Math.Sin(s), 3);
        }
    }
}
