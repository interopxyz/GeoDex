﻿using System;

namespace Geodex.Curves.Open
{
    public class Catenary : Curve
    {
        public Catenary() : base()
        {

        }
        public Catenary(double t) : base()
        {
            this.T = t; 
        }

        protected override void Evaluate()
        {
        }
    }
}