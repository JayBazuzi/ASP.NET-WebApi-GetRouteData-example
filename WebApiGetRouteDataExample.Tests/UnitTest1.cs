using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiGetRouteDataExample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RouteToGetUser()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:4567/api/users/me");

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            config.EnsureInitialized();

            var result = config.Routes.GetRouteData(request);

            Assert.AreEqual("api/{controller}/{id}", result.Route.RouteTemplate);
        }
    }
}
