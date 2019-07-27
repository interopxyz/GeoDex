using System;

namespace Geodex.Curves.Continous
{
    public class Cissoid : Curve
    {

        public Cissoid() : base()
        {

        }

        public Cissoid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t*Math.PI;

            double i = Math.Tan(s) * Math.Sin(s);

            p.X = i*Math.Cos(s);
            p.Y = i * Math.Sin(s);
        }
    }
}
