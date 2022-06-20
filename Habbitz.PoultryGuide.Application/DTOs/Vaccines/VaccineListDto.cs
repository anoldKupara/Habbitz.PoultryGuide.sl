using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Vaccines
{
    public class VaccineListDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
        public string Alternative { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
    }
}