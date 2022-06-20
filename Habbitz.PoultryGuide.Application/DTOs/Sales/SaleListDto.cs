using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Sales
{
    public class SaleListDto : BaseDto
    {
        public string ItemPurchased { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}