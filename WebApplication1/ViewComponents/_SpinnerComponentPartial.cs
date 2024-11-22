using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _SpinnerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
