using System;

namespace Geodex
{
    public class UV
    {

        #region members

        public double U = 0;
        public double V = 0;

        #endregion

        #region constructor

        public UV()
        {

        }

        public UV(UV uv)
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public UV(double u, double v)
        {
            this.U = u;
            this.V = v;
        }

        #endregion

        #region properties

        #endregion

        #region methods

        #endregion

    }
}
