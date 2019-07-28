using System;

namespace Geodex.Curves.Closed
{
    public class Superformula : Curve
    {
        public double Sides = 10;
        public double A = 2;
        public double B = 2;
        public double C = 2;
        public double D = 2;
        public double E = 2;
        public Superformula() : base()
        {

        }

        public Superformula(double sides, double a, double b, double c, double d, double e) : base()
        {
            this.Sides = sides;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
        }

        public Superformula(double t, double sides, double a, double b, double c, double d, double e) : base()
        {
            this.Sides = sides;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = Math.Pow(Math.Abs(1 / A * Math.Abs(Math.Cos(Sides * s / 4))), D) + Math.Pow(Math.Abs(1 / B + Math.Abs(Math.Sin(Sides * s / 4))), E);
            double v = Math.Pow(Math.Abs(u), (-1 / C));

            p.X = v * Math.Cos(s);
            p.Y = v * Math.Sin(s);
        }
    }
}
