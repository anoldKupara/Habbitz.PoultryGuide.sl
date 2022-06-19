using Habbitz.PoultryGuide.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Domain.Entities
{
    public class Sale : BaseDomainEntity
    {
        public string ItemPurchased { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}