using System;

namespace Geodex.Curves.Fixed
{
    public class Kampyle : Curve
    {

        double A = 1;
        double B = 1;

        public Kampyle() : base()
        {

        }

        public Kampyle(double a, double b) : base()
        {
            this.A = a;
            this.B = b; 
        }

        public Kampyle(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = Math.Pow(B, 2) / (A * Math.Pow(Math.Cos(s), 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);
        }
    }
}
