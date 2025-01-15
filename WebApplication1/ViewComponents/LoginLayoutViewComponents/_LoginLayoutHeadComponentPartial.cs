using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.LoginLayoutViewComponents
{
    public class _LoginLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

