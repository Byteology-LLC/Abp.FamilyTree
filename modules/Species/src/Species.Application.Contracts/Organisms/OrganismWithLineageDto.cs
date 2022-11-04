using System;
using System.Collections.Generic;
using System.Text;

namespace Species.Organisms
{
    public class OrganismWithLineageDto<TOrganismType>
        where TOrganismType : OrganismDto
    {
        public TOrganismType Organism { get; set; }
        public TOrganismType Mother { get; set; }
        public TOrganismType Father { get; set; }
        public ICollection<TOrganismType> Offspring { get; set; }
    }
}
