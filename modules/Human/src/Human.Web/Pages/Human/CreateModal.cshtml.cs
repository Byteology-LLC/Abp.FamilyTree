using AutoMapper.Internal.Mappers;
using Human.Humanity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Human.Web.Pages.Human
{
    public class CreateModalModel : HumanPageModel
    {
        [BindProperty]
        public HumanCreateDto Human { get; set; }

        public List<SelectListItem> MotherLookupList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem("","")
        };

        public List<SelectListItem> FatherLookupList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem("","")
        };

        private readonly IHumanAppService AppService;

        public CreateModalModel(IHumanAppService appService)
        {
            AppService = appService;
        }

        public async Task OnGetAsync()
        {
            Human = new HumanCreateDto();
            var humans = await AppService.GetListAsync();

            MotherLookupList.AddRange(humans.Items.Select(s => new SelectListItem(s.Name, s.Id.ToString())).ToList());
            FatherLookupList.AddRange(humans.Items.Select(s => new SelectListItem(s.Name, s.Id.ToString())).ToList());
        }

        public async Task<NoContentResult> OnPostAsync()
        {

            await AppService.CreateAsync(Human);
            return NoContent();
        }
    }
}
