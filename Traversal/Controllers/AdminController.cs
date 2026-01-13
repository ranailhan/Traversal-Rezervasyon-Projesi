using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        }
        public PartialViewResult PartialMenuInner()
        { 
            return PartialView(); 
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter() 
        { 
            return PartialView();
        }
    }
}
