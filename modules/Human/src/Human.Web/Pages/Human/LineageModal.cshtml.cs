using Human.Humanity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Species.Organisms;
using System;
using System.Threading.Tasks;

namespace Human.Web.Pages.Human
{
    public class LineageModalModel : HumanPageModel
    {
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public OrganismWithLineageDto<HumanDto> Human { get; set; }

        private readonly IHumanAppService AppService;

        public LineageModalModel(IHumanAppService appService)
        {
            AppService = appService;
        }

        public async Task OnGetAsync()
        {
            var human = await AppService.GetOrganismWithLineageAsync(Id);
            Human = human;       
        }
    }
}
