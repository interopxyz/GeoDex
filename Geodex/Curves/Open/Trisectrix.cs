﻿using System;

namespace Geodex.Curves.Open
{
    public class Trisectrix : Curve
    {

        #region members

        #endregion

        #region constructors

        public Trisectrix() : base()
        {

        }

        public Trisectrix(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = (s * (Math.Pow(s, 2) - 3)) / (Math.Pow(s, 2) + 1);
            p.Y = (Math.Pow(s, 2) - 3) / (Math.Pow(s, 2) + 1);

        }

        #endregion

    }
}
