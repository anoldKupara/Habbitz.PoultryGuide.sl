using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Inventories
{
    public class InventoryDto : BaseDto
    {
        public string ItemName { get; set; }
        public string Purpose { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
