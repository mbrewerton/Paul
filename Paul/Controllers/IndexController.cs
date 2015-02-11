
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using DAL.Models;
using DAL.Models.Dto;

namespace Paul.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            var db = new DatabaseHelper();
            var films = db.GetAllFilms();
            return View(db.GetAllFilms());
            //return View(new PaulViewModel());
        }

        [HttpPost]
        public ActionResult GetData()
        {
            return null;
        }

        public ActionResult GetFilms()
        {
            return null;
        }
    }
}