using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Species.Organisms
{
    public class EfCoreOrganismRepository<TOrganismType, TDbContext> : EfCoreRepository<TDbContext, TOrganismType, Guid>, IOrganismRepository<TOrganismType>
        where TOrganismType : Organism
        where TDbContext : class, IEfCoreDbContext
    {
        public EfCoreOrganismRepository(IDbContextProvider<TDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<TOrganismType> GetOrganismAsync(Guid organismId)
        {
            return await (await GetQueryableAsync()).FirstOrDefaultAsync(f => f.Id == organismId);
        }

        public async Task<OrganismWithLineage<TOrganismType>> GetOrganismWithLineageAsync(Guid organismId)
        {
            var organism = await (await GetQueryableAsync()).FirstOrDefaultAsync(f => f.Id == organismId);

            if (organism == null || organism == default(TOrganismType))
                throw new BusinessException($"Unable to locate organism with id: {organismId}");

            var mother = organism.Mother.HasValue ? await (await GetQueryableAsync()).FirstOrDefaultAsync(f => f.Id == organism.Mother.Value) : null;
            var father = organism.Father.HasValue ? await (await GetQueryableAsync()).FirstOrDefaultAsync(f => f.Id == organism.Father.Value) : null;

            return new OrganismWithLineage<TOrganismType>
            {
                Organism = organism,
                Mother = mother,
                Father = father,
                Offspring = await GetOffspringAsync(organismId)
            };
        }

        public async Task<List<TOrganismType>> GetOffspringAsync(Guid orgamismId)
        {
            return await (await GetQueryableAsync()).Where(w => w.Mother == orgamismId || w.Father == orgamismId).ToListAsync();
        }

        
    }
}
