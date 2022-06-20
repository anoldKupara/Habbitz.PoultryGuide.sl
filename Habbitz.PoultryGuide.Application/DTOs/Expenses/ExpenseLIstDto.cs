using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Expenses
{
    public class ExpenseLIstDto : BaseDto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
    }
}
