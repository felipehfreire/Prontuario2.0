using H1.Services.Validations;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace H1.Controllers
{
    public class ControllerBase : Controller
    {
        public string CurrentUserID = string.Empty;
        public ControllerBase()
        {
            if(System.Web.HttpContext.Current.User != null)
            {
                CurrentUserID = System.Web.HttpContext.Current.User.Identity.GetUserId();
            }
            
        }

        protected void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        protected void AddErrors(H1ValidationResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }


    }
}