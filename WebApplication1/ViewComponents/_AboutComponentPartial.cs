using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
