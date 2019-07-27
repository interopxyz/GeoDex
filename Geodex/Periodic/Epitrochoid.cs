using System;

namespace Geodex.Curves.Periodic
{
    public class Epitrochoid : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;
        public double Distance = 2;

        public Epitrochoid() : base()
        {

        }

        public Epitrochoid(double innerRadius, double rollerRadius, double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
        }

        public Epitrochoid(double t, double innerRadius, double rollerRadius, double distance) : base()
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
            double v = u/ RollerRadius * s;

            p.X = u * Math.Cos(s) - Distance * Math.Cos(v);
            p.Y = u * Math.Sin(s) - Distance * Math.Sin(v);
        }
    }
}
