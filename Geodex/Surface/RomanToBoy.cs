using System;

namespace Geodex.Surface
{
    public class RomanToBoy : Field
    {
        public double A = 1.0;
        public RomanToBoy() : base()
        {

        }

        public RomanToBoy(double a) : base()
        {
            this.A= a;
        }

        public RomanToBoy(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            double k = 2 - (A%1.0) * Math.Sqrt(2) * Math.Sin(3 * i) * Math.Sin(2 * j);

            p.X = (Math.Sqrt(2) * Math.Cos(2 * i) * Math.Pow(Math.Cos(j), 2) + Math.Cos(i) * Math.Sin(2 * j)) / k;
            p.Y = (Math.Sqrt(2) * Math.Sin(2 * i) * Math.Pow(Math.Cos(j), 2) - Math.Sin(i) * Math.Sin(2 * j)) / k;
            p.Z = (3 * Math.Pow(Math.Cos(j), 2)) / k;

        }
    }
}