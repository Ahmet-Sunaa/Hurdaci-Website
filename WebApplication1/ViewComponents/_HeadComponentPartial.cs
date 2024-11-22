using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
