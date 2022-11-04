using Species.Organisms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Humanity
{
    public interface IHumanAppService : IOrganismAppService<HumanDto, HumanCreateDto, HumanUpdateDto>
    {
    }
}
