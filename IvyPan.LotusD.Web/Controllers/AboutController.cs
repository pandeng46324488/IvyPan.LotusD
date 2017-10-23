using System.Web.Mvc;

namespace IvyPan.LotusD.Web.Controllers
{
    public class AboutController : LotusDControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}