using Microsoft.AspNetCore.Mvc;
using Species.Organisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;

namespace Human.Humanity
{
    [RemoteService(Name = "Humanity")]
    [Area("humanity")]
    [ControllerName("Human")]
    [Route("api/humanity/humans")]
    public class HumanController : OrganismController<IHumanAppService, HumanDto, HumanCreateDto, HumanUpdateDto>, IHumanAppService
    {
        public HumanController(IHumanAppService appService) : base(appService)
        {
        }
    }
}
