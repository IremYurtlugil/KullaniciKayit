using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewComp
{
    public class CariUpdateViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Cari vm)
        {
            IViewComponentResult viewComponentResult = await Task.FromResult(View("../CariUpdate/CariUpdateCompView",vm)); //view için yol tanımlama.
            return viewComponentResult;
        }
    }
}
