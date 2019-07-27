using System;
using System.Collections.Generic;
using System;

namespace Geodex.Curves.Other
{
    public class HippiasQuadratrix : Curve
    {
        public double A = 1.0;

        public HippiasQuadratrix() : base()
        {

        }
        public HippiasQuadratrix(double a) : base()
        {
            this.A = a;
        }

        public HippiasQuadratrix(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = 2 * A * s / (Math.PI * Math.Sin(s));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}