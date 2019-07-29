using System;

namespace Geodex.Volumes
{
    public class AstroidalEllipsoid : Field
    {

        #region members
        
        #endregion

        #region constructors

        public AstroidalEllipsoid() : base()
        {

        }

        public AstroidalEllipsoid(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;
            
            p.X = Math.Pow(Math.Cos(i), 3) * Math.Pow(Math.Cos(j), 3);
            p.Y = Math.Pow(Math.Sin(i), 3) * Math.Pow(Math.Cos(j), 3);
            p.Z = Math.Pow(Math.Sin(j), 3);

        }

        #endregion

    }
}