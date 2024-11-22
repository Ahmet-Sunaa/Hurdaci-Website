using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _TopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
