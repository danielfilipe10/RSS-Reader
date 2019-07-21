using System.Web.Mvc;

namespace RSS_Reader.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            return View();
        }

        
    }
}