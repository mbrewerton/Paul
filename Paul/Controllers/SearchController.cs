using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using AttributeRouting.Web.Http;
using DAL.Services;
using System.Web.Http;

namespace Paul.Controllers
{
    [RoutePrefix("api/Search")]
    public class SearchController : ApiController
    {
        [HttpGet]
        [GET("Search")]
        public HttpResponseMessage Search()
        {
            
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}