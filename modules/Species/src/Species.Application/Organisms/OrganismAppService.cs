using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Species.Organisms
{
    public abstract class OrganismAppService<TOrganismRepositoryType, TOrganismType, TOrganismDtoType, TOrganismCreateDtoType, TOrganismUpdateDtoType> : ApplicationService, IOrganismAppService<TOrganismDtoType, TOrganismCreateDtoType, TOrganismUpdateDtoType>
        where TOrganismDtoType : OrganismDto
        where TOrganismType : Organism
        where TOrganismRepositoryType : IOrganismRepository<TOrganismType>
    {
        private readonly TOrganismRepositoryType OrganismRepository;

        protected OrganismAppService(TOrganismRepositoryType organismRepository)
        {
            OrganismRepository = organismRepository;
        }

        public abstract Task<TOrganismDtoType> CreateAsync(TOrganismCreateDtoType input);

        public async Task<ListResultDto<TOrganismDtoType>> GetListAsync()
        {
            var list = await OrganismRepository.GetListAsync();

            return new ListResultDto<TOrganismDtoType>()
            {
                Items = ObjectMapper.Map<List<TOrganismType>, List<TOrganismDtoType>>(list)
            };
        }

        public async Task<List<TOrganismDtoType>> GetOffspringAsync(Guid orgamismId)
        {
            return ObjectMapper.Map<List<TOrganismType>, List<TOrganismDtoType>>(await OrganismRepository.GetOffspringAsync(orgamismId));
        }

        public async Task<TOrganismDtoType> GetOrganismAsync(Guid organismId)
        {
            return ObjectMapper.Map<TOrganismType, TOrganismDtoType>(await OrganismRepository.GetOrganismAsync(organismId));
        }

        public async Task<OrganismWithLineageDto<TOrganismDtoType>> GetOrganismWithLineageAsync(Guid organismId)
        {
            return ObjectMapper.Map<OrganismWithLineage<TOrganismType>, OrganismWithLineageDto<TOrganismDtoType>>(await OrganismRepository.GetOrganismWithLineageAsync(organismId));
        }

        public abstract Task<TOrganismDtoType> UpdateAsync(Guid organismId, TOrganismUpdateDtoType input);

    }
}
