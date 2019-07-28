using System;

namespace Geodex.Curves.Volumetric
{
    public class TorusKnot : Curve
    {
        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;
        public double D = 1.0;

        public TorusKnot() : base()
        {

        }

        public TorusKnot(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = D * Math.Cos(B * s) + C;

            p.X = i * Math.Cos(D * s);
            p.Y = i * Math.Sin(D * s);
            p.Z = D * Math.Sin(B * s);

        }
    }
}
