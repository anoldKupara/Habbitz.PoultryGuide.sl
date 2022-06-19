using Habbitz.PoultryGuide.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Domain.Entities
{
    public  class Expense : BaseDomainEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
    }
}
