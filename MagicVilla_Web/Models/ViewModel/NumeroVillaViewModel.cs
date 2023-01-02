using MagicVilla_Web.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModel
{
    public class NumeroVillaViewModel
    {

        public NumeroVillaViewModel()
        {
            NumeroVilla = new NumeroVillaCreateDto();
        }

        public NumeroVillaCreateDto NumeroVilla { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }

    }
}
