using Habbitz.PoultryGuide.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Application.DTOs.BirdCategory
{
    public class BirdCategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Breed { get; set; }
    }
}
