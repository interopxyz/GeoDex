using System;

namespace Geodex.Volumes
{
    public class AstroidalEllipsoid : Field
    {
        public double A = 2.0;

        public AstroidalEllipsoid() : base()
        {

        }

        public AstroidalEllipsoid(double a) : base()
        {
            this.A = a;
        }

        public AstroidalEllipsoid(UV uv, double a) : base()
        {
            this.A = a;
            this.U = uv.U;
            this.V = uv.V;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;
            
            p.X = Math.Pow(Math.Cos(i), 3) * Math.Pow(Math.Cos(j), 3);
            p.Y = Math.Pow(Math.Sin(i), 3) * Math.Pow(Math.Cos(j), 3);
            p.Z = Math.Pow(Math.Sin(j), 3);
        }
    }
}