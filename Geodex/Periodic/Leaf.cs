using System;

namespace Geodex.Curves.Periodic
{
    public class Leaf : Curve
    {
        public double InnerRadius = 1;
        public double RollerRadius = 2;
        public double Distance = 1;
        public Leaf() : base()
        {

        }

        public Leaf(double innerRadius, double rollerRadius,double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
        }

        public Leaf(double t, double innerRadius, double rollerRadius, double distance) : base()
        {
            this.InnerRadius = innerRadius;
            this.RollerRadius = rollerRadius;
            this.Distance = distance;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = InnerRadius + RollerRadius * Math.Cos(Distance * s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}
