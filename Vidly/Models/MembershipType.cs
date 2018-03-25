﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SingupFree { get; set; }
        public byte DurationInMonth { get; set; }
        public int Discount { get; set; }
        public string Name { get; set; }
    }
}