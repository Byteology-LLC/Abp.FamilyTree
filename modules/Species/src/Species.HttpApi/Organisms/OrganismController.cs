using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Species.Organisms
{
    public abstract class OrganismController<TOrganismAppService, TOrganismDtoType, TOrganismCreateDtoType, TOrganismUpdateDtoType> : AbpController, IOrganismAppService<TOrganismDtoType, TOrganismCreateDtoType, TOrganismUpdateDtoType>
        where TOrganismDtoType: OrganismDto
        where TOrganismAppService: IOrganismAppService<TOrganismDtoType, TOrganismCreateDtoType, TOrganismUpdateDtoType>
    {
        private readonly TOrganismAppService AppService;
        

        protected OrganismController(TOrganismAppService appService)
        {
            AppService = appService;
        }

        [HttpPost]
        public Task<TOrganismDtoType> CreateAsync(TOrganismCreateDtoType input)
        {
            return AppService.CreateAsync(input);
        }

        [HttpGet]
        public Task<ListResultDto<TOrganismDtoType>> GetListAsync()
        {
            return AppService.GetListAsync();
        }

        [HttpGet]
        [Route("{id}/offspring")]
        public Task<List<TOrganismDtoType>> GetOffspringAsync(Guid orgamismId)
        {
            return AppService.GetOffspringAsync(orgamismId);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<TOrganismDtoType> GetOrganismAsync(Guid organismId)
        {
            return AppService.GetOrganismAsync(organismId);
        }

        [HttpGet]
        [Route("{id}/lineage")]
        public Task<OrganismWithLineageDto<TOrganismDtoType>> GetOrganismWithLineageAsync(Guid organismId)
        {
            return AppService.GetOrganismWithLineageAsync(organismId);
        }

        [HttpPut]
        [Route("{organismId}")]
        public Task<TOrganismDtoType> UpdateAsync(Guid organismId, TOrganismUpdateDtoType input)
        {
            return AppService.UpdateAsync(organismId, input);
        }
    }
}
