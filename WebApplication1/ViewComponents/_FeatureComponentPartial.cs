using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL.Context;

namespace WebApplication1.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        HurdaciContext HurdaciContext = new HurdaciContext();
        public IViewComponentResult Invoke()
        {
            var values = HurdaciContext.Abouts.ToList();
            return View(values);
        }
    }
}
