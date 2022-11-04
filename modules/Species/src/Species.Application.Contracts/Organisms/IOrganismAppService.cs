using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Species.Organisms
{
    public interface IOrganismAppService<TOrganismDtoType, TOrganismCreateDtoType, TOrganismUpdateDtoType> : IApplicationService
        where TOrganismDtoType: OrganismDto
    {
        public Task<TOrganismDtoType> CreateAsync(TOrganismCreateDtoType input);
        public Task<TOrganismDtoType> UpdateAsync(Guid organismId, TOrganismUpdateDtoType input);
        public Task<ListResultDto<TOrganismDtoType>> GetListAsync();
        public Task<TOrganismDtoType> GetOrganismAsync(Guid organismId);
        public Task<OrganismWithLineageDto<TOrganismDtoType>> GetOrganismWithLineageAsync(Guid organismId);
        public Task<List<TOrganismDtoType>> GetOffspringAsync(Guid orgamismId);
    }
}
