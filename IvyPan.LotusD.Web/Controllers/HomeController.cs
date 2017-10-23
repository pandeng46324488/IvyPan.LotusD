using System.Web.Mvc;

namespace IvyPan.LotusD.Web.Controllers
{
    public class HomeController : LotusDControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}