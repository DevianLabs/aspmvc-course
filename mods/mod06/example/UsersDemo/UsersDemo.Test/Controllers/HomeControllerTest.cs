using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using UsersDemo.Controllers;

namespace UsersDemo.Test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexTest()
        {
            HomeController controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.AreEqual(result.GetType(), typeof(ViewResult));
        }
    }
}
