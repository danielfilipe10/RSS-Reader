using RSS_Reader.Business;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RSS_Reader.Controllers
{
    public class RssController : Controller
    {
        private IRssBusiness _rssBusiness;
        public RssController(IRssBusiness rssBusiness)
        {
            _rssBusiness = rssBusiness;
        }
        // GET: Rss
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Submit(string url)
        {
            var rssList = await _rssBusiness.GetListRssItems(url);

            return View(rssList);
        }
    }
}