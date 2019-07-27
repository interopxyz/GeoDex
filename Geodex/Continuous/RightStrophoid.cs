using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Geodex.Curves.Continous
{
    public class RightStrophoid : Curve
    {

        public RightStrophoid() : base()
        {

        }

        public RightStrophoid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t*Math.PI;

            double i = Math.Cos(2 * s) / Math.Cos(s);

            p.X = i*Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
