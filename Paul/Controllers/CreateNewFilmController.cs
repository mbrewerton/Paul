using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paul.Controllers
{
    public class CreateNewFilmController : Controller
    {
        // GET: Films
        public ActionResult Index()
        {
            return View("CreateNewFilm");
        }

        [HttpPost]
        public ActionResult AddFilm(string filmName)
        {
            Console.Write("here");
            return null;
        }
    }
}
