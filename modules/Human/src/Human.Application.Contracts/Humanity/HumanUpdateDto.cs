using JetBrains.Annotations;
using Species.Organisms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Humanity
{
    public class HumanUpdateDto : OrganismCreateUpdateDto
    {
        [CanBeNull]
        public string HairColor { get; set; }
        [CanBeNull]
        public string EyeColor { get; set; }
    }
}
