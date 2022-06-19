﻿using Habbitz.PoultryGuide.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Domain.Entities
{
    public class Inventory : BaseDomainEntity
    {
        public string ItemName { get; set; }
        public string Purpose { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
