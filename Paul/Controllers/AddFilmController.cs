using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Paul.Models;
using DAL.Models;

namespace Paul.Controllers
{
    public class AddFilmController : Controller
    {
        private DatabaseHelper db = new DatabaseHelper();

        // GET: AddFilm
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateFilm()
        {
            throw new NotImplementedException();
        }

        public ActionResult EditFilm()
        {
            throw new NotImplementedException();
        }
    }
}