﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AF
{
    class SchweppesFactory:AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new SchweppesWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new SchweppesBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new SchweppesCover();
        }
    }
}
