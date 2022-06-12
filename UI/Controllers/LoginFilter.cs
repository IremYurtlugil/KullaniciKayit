using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace UI.Controllers
{
   public class LoginFilter : IAuthorizationFilter
    {        public void Yonlendir(AuthorizationFilterContext context)
        {
            context.Result = new RedirectResult("/Home/Index");
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userSession = context.HttpContext.Session.GetJson<Kullanici>("bilgi");
            if (userSession == null)
            {
                Yonlendir(context);
            }
        }
    }
}