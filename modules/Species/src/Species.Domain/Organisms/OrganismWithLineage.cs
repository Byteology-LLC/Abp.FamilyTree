using System;
using System.Collections.Generic;
using System.Text;

namespace Species.Organisms
{
    public class OrganismWithLineage<TOrganismType>
        where TOrganismType : Organism
    {
        public TOrganismType Organism { get; set; }
        public TOrganismType Mother { get; set; }
        public TOrganismType Father { get; set; }
        public ICollection<TOrganismType> Offspring { get; set; }
    }
}
