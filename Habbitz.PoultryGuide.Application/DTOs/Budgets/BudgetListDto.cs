using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Budgets
{
    public class BudgetListDto : BaseDto
    {
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string SourceOfFund { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
    }
}