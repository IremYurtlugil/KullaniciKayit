using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewComp
{
    public class CariEkleGuncelleViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IViewComponentResult viewComponentResult = await Task.FromResult(View("../CariEkleGuncelle/CariEkleGuncelleCompView")); //view için yol tanımlama.
            return viewComponentResult;
        }


    }
}
