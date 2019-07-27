using System;

namespace Geodex.Curves.Periodic
{
    public class Cardioid : Curve
    {

        public Cardioid() : base()
        {

        }

        public Cardioid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = 1 + Math.Cos(s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
