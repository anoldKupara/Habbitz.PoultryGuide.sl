using Habbitz.PoultryGuide.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Domain.Entities
{
    public class PaymentMethod : BaseDomainEntity
    {
        public string Name { get; set; }
    }
}
