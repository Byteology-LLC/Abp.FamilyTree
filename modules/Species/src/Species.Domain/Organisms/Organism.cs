using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Species.Organisms
{
    public abstract class Organism : FullAuditedAggregateRoot<Guid>, IOrganism
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public Guid? Mother { get; set; }
        public Guid? Father { get; set; }

        public Organism() : base() { }
        public Organism(Guid id): base(id)
        {

        }
    }
}
