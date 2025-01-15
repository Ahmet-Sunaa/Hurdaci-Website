using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApplication1.DAL.Context;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
        
    {
        HurdaciContext HurdaciContext = new HurdaciContext();
        public IActionResult Index()
        {
            return View();
        }

    }
}
