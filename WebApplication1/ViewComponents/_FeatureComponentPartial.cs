using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
