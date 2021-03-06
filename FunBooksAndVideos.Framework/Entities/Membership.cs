﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class Membership : PurchasableItem
    {
        public MembershipType Type { get; set; }

        public override string ToString() => $"{ Type } Club Membership";

    }
}
