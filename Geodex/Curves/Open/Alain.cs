using System;

namespace Geodex.Curves.Open
{
    public class Alain : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public Alain() : base()
        {

        }
        public Alain(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Alain(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
             
            double i = Math.Sqrt(Math.Pow(A, 2) * Math.Pow(Math.Cos(s), 2) - Math.Pow(B, 2) * Math.Pow(Math.Sin(s), 2)) / Math.Cos(s * 2);
            
            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
