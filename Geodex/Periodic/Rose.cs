using System;

namespace Geodex.Curves.Periodic
{
    public class Rose : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;
        public Rose() : base()
        {

        }

        public Rose(double innerRadius, double rollerRadius) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
        }

        public Rose(double t, double innerRadius, double rollerRadius) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = Math.Cos(InnerRadius / RollerRadius * s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}
