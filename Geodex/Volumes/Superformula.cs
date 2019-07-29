using System;

namespace Geodex.Volumes
{
    public class Superformula : Field
    {

        #region members

        public double A = 8.0;
        public double B = 16.0;
        public double C = 1.0;
        public double D = 1.0;
        public double E = 1.0;
        public double F = 1.0;
        public double G = 1.0;
        public double H = 1.0;
        public double J = 1.0;
        public double K = 1.0;
        public double M = 1.0;
        public double N = 1.0;

        #endregion

        #region constructors
        
        public Superformula() : base()
        {

        }

        public Superformula(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public Superformula(UV uv, double a, double b, double c, double d, double e, double f, double g, double h, double j, double k, double m, double n) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
            this.F = f;
            this.G = g;
            this.H = h;
            this.J = j;
            this.K = k;
            this.M = m;
            this.N = n;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI ;
            double j = V * Math.PI;

            double r = Math.Pow(Math.Abs(Math.Pow(Math.Abs(Math.Cos(A * i / 4) / C),J) + Math.Pow(Math.Abs(Math.Sin(A * i / 4) / E), M)), (-1 / G));
            double s = Math.Pow(Math.Abs(Math.Pow(Math.Abs(Math.Cos(B * j / 4) / D), K) + Math.Pow(Math.Abs(Math.Sin(B * j / 4) / F), N)), (-1 / H));

            p.X = r * Math.Cos(i) * s * Math.Cos(j);
            p.Y = r * Math.Sin(i) * s * Math.Cos(j);
            p.Z = s * Math.Sin(j);

        }

        #endregion

    }
}