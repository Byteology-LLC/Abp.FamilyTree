using Human.Humanity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Human.Web.Pages.Human
{
    public class EditModalModel : HumanPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public HumanUpdateDto Human { get; set; }

        public List<SelectListItem> MotherLookupList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem("","")
        };

        public List<SelectListItem> FatherLookupList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem("","")
        };

        private readonly IHumanAppService AppService;

        public EditModalModel(IHumanAppService appService)
        {
            AppService = appService;
        }

        public async Task OnGetAsync()
        {
            var humanWithLineageDto = await AppService.GetOrganismWithLineageAsync(Id);
            Human = ObjectMapper.Map<HumanDto, HumanUpdateDto>(humanWithLineageDto.Organism);

            var humans = await AppService.GetListAsync();
            MotherLookupList.AddRange(humans.Items.Where(w=>w.Id != Id).Select(s => new SelectListItem(s.Name, s.Id.ToString())).ToList());
            FatherLookupList.AddRange(humans.Items.Where(w => w.Id != Id).Select(s => new SelectListItem(s.Name, s.Id.ToString())).ToList());
        }

        public async Task<NoContentResult> OnPostAsync()
        {

            await AppService.UpdateAsync(Id, Human);
            return NoContent();
        }
    }
}
