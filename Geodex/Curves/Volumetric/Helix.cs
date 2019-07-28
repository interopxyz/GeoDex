using System;

namespace Geodex.Curves.Volumetric
{
    public class Helix : Curve
    {

        public Helix() : base()
        {

        }

        public Helix(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Cos(s);
            p.Y = Math.Sin(s);
            p.Z = s;

        }
    }
}
