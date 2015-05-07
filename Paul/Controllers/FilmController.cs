using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using AttributeRouting.Web.Http;
using DAL.Services;
using System.Web.Http;

namespace Paul.Controllers
{
    [RoutePrefix("api/Film")]
    public class FilmController : ApiController
    {
        FilmService _service = new FilmService();

        [HttpGet]
        [GET("GetFilms")]
        public HttpResponseMessage GetFilms()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _service.GetFilms());
        }
        [HttpGet]
        [GET("Search")]
        public HttpResponseMessage Search(string searchTerm)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _service.Search(searchTerm));
        }
    }
}