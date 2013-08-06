using System.Web.Mvc;
using NServiceBus;
using TrashBin.Messages;

namespace TrashBin.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IBus _bus;

        public HomeController(IBus bus)
        {
            _bus = bus;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            _bus.Send(new CreateCompany{Name = "Software-Projects bvba"});
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
