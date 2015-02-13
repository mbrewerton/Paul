﻿
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using DAL.Models;
using DAL.Models.Dto;

namespace Paul.Controllers
{
    public class IndexController : Controller
    {
        DatabaseHelper _db = new DatabaseHelper();
        // GET: Index
        public ActionResult Index()
        {
            var films = _db.GetAllFilms();
            return View(_db.GetAllFilms());
            //return View(new PaulViewModel());
        }
    }
}