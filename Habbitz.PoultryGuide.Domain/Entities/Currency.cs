using Habbitz.PoultryGuide.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Domain.Entities
{
    public class Currency : BaseDomainEntity
    {
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public int Rate { get; set; }

    }
}
