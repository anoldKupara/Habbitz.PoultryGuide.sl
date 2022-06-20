using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.Currencies
{
    public class CreateCurrencyDto : BaseDto
    {
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public int Rate { get; set; }

    }
}