using System;

namespace Geodex.Curves.Closed
{
    public class Hypocycloid_A : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;

        public Hypocycloid_A() : base()
        {

        }

        public Hypocycloid_A(double innerRadius, double rollerRadius) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
        }

        public Hypocycloid_A(double t, double innerRadius, double rollerRadius) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double u = (InnerRadius - RollerRadius);
            double v = u/ RollerRadius;

            p.X = u * Math.Cos(s) + RollerRadius * Math.Cos(v * s);
            p.Y = u * Math.Sin(s) - RollerRadius * Math.Sin(v * s);
        }
    }
}
