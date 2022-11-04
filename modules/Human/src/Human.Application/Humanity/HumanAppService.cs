using Species.Organisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Humanity
{
    public class HumanAppService : OrganismAppService<IHumanRepository, Human, HumanDto, HumanCreateDto, HumanUpdateDto>, IHumanAppService
    {

        private IHumanRepository humanRepository;
        public HumanAppService(IHumanRepository organismRepository) : base(organismRepository)
        {
           humanRepository = organismRepository;
        }

        public override async Task<HumanDto> CreateAsync(HumanCreateDto input)
        {
            var human = new Human(GuidGenerator.Create())
            {
                Name = input.Name,
                DateOfBirth = input.DateOfBirth,
                DateOfDeath = input.DateOfDeath,
                Mother = input.Mother,
                Father = input.Father,
                HairColor = input.HairColor,
                EyeColor = input.EyeColor
            };

            return ObjectMapper.Map<Human, HumanDto>(await humanRepository.InsertAsync(human));
        }

        public override async Task<HumanDto> UpdateAsync(Guid organismId, HumanUpdateDto input)
        {
            var human = await humanRepository.GetOrganismAsync(organismId);

            human.Name = input.Name;
            human.DateOfBirth = input.DateOfBirth;
            human.DateOfDeath = input.DateOfDeath;
            human.Mother = input.Mother;
            human.Father = input.Father;
            human.HairColor = input.HairColor;
            human.EyeColor = input.EyeColor;

            return ObjectMapper.Map<Human, HumanDto>(await humanRepository.UpdateAsync(human));
        }
    }
}
