using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context c = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.DestinationCount = c.Destinations.Count();
            ViewBag.CustomerCount = c.Users.Count();
            return View();
        }
    }
}
