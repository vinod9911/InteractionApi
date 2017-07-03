using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net;
using IntractionApi.BusinessLogic;
using IntractionApi.Models;

namespace IntractionApi.Controllers
{
    public class HomeController : ApiController
    {
        [System.Web.Http.HttpGet]
        public HttpResponseMessage NewBusiness()
        {
            BusinessGetData bussData = new BusinessGetData();
            return Request.CreateResponse<IList<SampleData>>(HttpStatusCode.OK, bussData.GetData());
        }
    }
}
