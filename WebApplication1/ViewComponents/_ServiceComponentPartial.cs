using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _ServiceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
