using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _PartialGuideList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
