using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
