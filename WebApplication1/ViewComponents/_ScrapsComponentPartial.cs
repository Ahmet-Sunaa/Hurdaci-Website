/*using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL.Context;

namespace WebApplication1.ViewComponents
{
    public class _ScrapsComponentPartial : ViewComponent
    {
        HurdaciContext HurdaciContext = new HurdaciContext();
        public IViewComponentResult Invoke()
        {
            var values = HurdaciContext.Scraps.ToList();
            return View(values);
        }
    }
}
*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL.Context;

namespace WebApplication1.ViewComponents
{
    public class _ScrapsComponentPartial : ViewComponent
    {
        HurdaciContext HurdaciContext = new HurdaciContext();


        public IViewComponentResult Invoke()
        {
            var values = HurdaciContext.Scraps
                .Include(s => s.ScrapImgs) // Scrap ile ilişkili ScrapImg verilerini çek
                .ToList();
            return View(values);
        }
    }
}
