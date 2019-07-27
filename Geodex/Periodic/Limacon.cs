using System;

namespace Geodex.Curves.Periodic
{
    public class Limacon : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;
        public double Distance = 1;
        public Limacon() : base()
        {

        }

        public Limacon(double innerRadius, double rollerRadius, double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
        }

        public Limacon(double t, double innerRadius, double rollerRadius, double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = RollerRadius + InnerRadius * Math.Cos(s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}
