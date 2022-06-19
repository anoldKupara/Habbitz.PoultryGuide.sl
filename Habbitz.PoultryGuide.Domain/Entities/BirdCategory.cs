using Habbitz.PoultryGuide.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habbitz.PoultryGuide.Domain.Entities
{
    public class BirdCategory : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Breed { get; set; }
    }
}
