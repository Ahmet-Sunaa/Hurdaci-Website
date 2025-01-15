using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL.Context;

namespace WebApplication1.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        HurdaciContext HurdaciContext = new HurdaciContext();
        public IViewComponentResult Invoke()
        {
            var values = HurdaciContext.Contacts.ToList();
            return View(values);
        }
    }
}
