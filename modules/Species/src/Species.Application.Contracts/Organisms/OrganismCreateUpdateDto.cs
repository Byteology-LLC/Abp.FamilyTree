using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Species.Organisms
{
    public class OrganismCreateUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [CanBeNull]
        public DateTime? DateOfDeath { get; set; }
        [CanBeNull]
        public Guid? Mother { get; set; }
        [CanBeNull]
        public Guid? Father { get; set; }
    }
}
