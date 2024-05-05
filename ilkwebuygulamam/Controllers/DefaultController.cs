using Microsoft.AspNetCore.Mvc;

namespace ilkwebuygulamam.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
    }
}
