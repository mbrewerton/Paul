
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using DAL.Models; 

namespace Paul.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}