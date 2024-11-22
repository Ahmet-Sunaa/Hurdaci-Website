using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL.Context;
using WebApplication1.DAL.ViewModel;

namespace WebApplication1.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent

    {
        HurdaciContext HurdaciContext = new HurdaciContext();

        public IViewComponentResult Invoke()
        {
            var viewModel = new FooterViewModel
            {
                Contacts = HurdaciContext.Contacts.ToList(),
                Scraps = HurdaciContext.Scraps.ToList()
            };

            return View(viewModel);
        }
    }
}
