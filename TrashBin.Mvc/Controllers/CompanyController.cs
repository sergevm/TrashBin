using System.Web.Mvc;
using NServiceBus;
using TrashBin.Messages;

namespace TrashBin.Mvc.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IBus _bus;

        public CompanyController(IBus bus)
        {
            _bus = bus;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Companies";
            return View();
        }
    }
}
