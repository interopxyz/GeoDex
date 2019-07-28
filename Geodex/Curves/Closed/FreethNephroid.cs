using System;

namespace Geodex.Curves.Closed
{
    public class FreethNephroid : Curve
    {
        double A = 1.0;

        public FreethNephroid() : base()
        {

        }

        public FreethNephroid(double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        public FreethNephroid(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = (1 + 2 * Math.Sin(s / 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
