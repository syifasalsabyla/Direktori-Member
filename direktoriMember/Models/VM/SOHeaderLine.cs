﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriMember.Models.VM
{
    public class SOHeaderLine
    {
        public SOHeader SOHeader { get; set; }
        public List<SOLine> SOLine { get; set; }
    }
}
