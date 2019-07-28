
using System;

namespace Geodex.Curves.Fixed
{
    public class Bifolium : Curve
    {
        double A = 0;
        double B = 1;
        public Bifolium() : base()
        {

        }

        public Bifolium(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        public Bifolium(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = (A * Math.Cos(s) + B * Math.Sin(s)) * Math.Pow(Math.Cos(s), 2);
            
            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}

