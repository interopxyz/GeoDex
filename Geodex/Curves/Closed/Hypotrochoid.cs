using System;

namespace Geodex.Curves.Closed
{
    public class Hypotrochoid : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;
        public double Distance = 2;

        public Hypotrochoid() : base()
        {

        }

        public Hypotrochoid(double innerRadius, double rollerRadius, double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
        }

        public Hypotrochoid(double t, double innerRadius, double rollerRadius, double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double u = (InnerRadius + RollerRadius);
            double v = u/ RollerRadius;

            p.X = u * Math.Cos(s) + RollerRadius * Math.Cos(v * s);
            p.Y = u * Math.Sin(s) - RollerRadius * Math.Sin(v * s);
        }
    }
}
