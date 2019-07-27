using System;

namespace Geodex.Curves.Periodic
{
    public class Epicycloid : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;
        public Epicycloid() : base()
        {

        }

        public Epicycloid(double innerRadius, double rollerRadius) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
        }

        public Epicycloid(double t, double innerRadius, double rollerRadius) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            double u = (InnerRadius + RollerRadius);
            double v = u / RollerRadius;

            p.X = u * Math.Cos(s) - RollerRadius * Math.Cos(v * s);
            p.Y = u * Math.Sin(s) - RollerRadius * Math.Sin(v * s);
        }
    }
}
