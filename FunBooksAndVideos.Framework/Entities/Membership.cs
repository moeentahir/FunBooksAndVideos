﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class Membership : Commodity
    {
        public Membership(List<IRule<Membership>> postProcessingRules) : base(postProcessingRules.OfType<IRule<Commodity>>())
        {

        }
    }
}
