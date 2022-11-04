using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Species.Organisms
{
    public interface IOrganismRepository<TOrganismType> : IRepository<TOrganismType, Guid>
        where TOrganismType : Organism
    {
        public Task<TOrganismType> GetOrganismAsync(Guid organismId);
        public Task<OrganismWithLineage<TOrganismType>> GetOrganismWithLineageAsync(Guid organismId);
        public Task<List<TOrganismType>> GetOffspringAsync(Guid orgamismId);
    }
}
