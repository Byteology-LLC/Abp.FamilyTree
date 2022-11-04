using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Species.Organisms
{
    public class OrganismDto: FullAuditedEntityDto<Guid>, IOrganismDto
    {
        [NotNull]
        public string Name { get; set; }
        [NotNull]
        public DateTime DateOfBirth { get; set; }
        [CanBeNull]
        public DateTime? DateOfDeath { get; set; }
        [CanBeNull]
        public Guid? Mother { get; set; }
        [CanBeNull]
        public Guid? Father { get; set; }
    }
}
