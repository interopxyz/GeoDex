using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex
{
    public class UV
    {
        public double U = 0;
        public double V = 0;

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

    }
}
