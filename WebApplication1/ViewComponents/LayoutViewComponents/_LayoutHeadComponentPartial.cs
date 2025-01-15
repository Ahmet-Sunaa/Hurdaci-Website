using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
