using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntractionApi.Tests.Controllers
{
    public class HomeControllerTest
    {
        public void TestHomeControllerNewBusiness()
        {
            var controller = new IntractionApi.Controllers.HomeController();
            controller.Request = new System.Net.Http.HttpRequestMessage();
            controller.Configuration = new System.Web.Http.HttpConfiguration();
            var response = controller.NewBusiness();
            //Assert.AreEqual("1", response.)
        }

    }
}
