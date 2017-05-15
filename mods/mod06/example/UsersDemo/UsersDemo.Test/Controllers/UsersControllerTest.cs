using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UsersDemo.Controllers;
using UsersDemo.Models;
using UsersDemo.Test.Models;

namespace UsersDemo.Test.Controllers
{
    [TestClass]
    public class UsersControllerTest
    {
       
        [TestMethod]
        public void IndexView()
        {
            var userController = GetUsersController(new FakeUserRepository());
            ViewResult result = userController.Index("") as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }


       
        private static UsersController GetUsersController(IUserRepository userRepository)
        {
            UsersController userController = new UsersController(userRepository);
            userController.ControllerContext = new ControllerContext()
            {
                Controller = userController,
                RequestContext = new RequestContext(new MockHttpContext(), new RouteData())
            };
            return userController;
        }

      
        [TestMethod]
        public void GetAllUserFromRepository()
        {
            // Arrange
            User user1 = GetUserName(1, "U", "U", "U", DateTime.Now, 1);
            User user2 = GetUserName(2, "U", "U", "U", DateTime.Now, 1);
            FakeUserRepository userRepository = new FakeUserRepository();
            userRepository.Create(user1);
            userRepository.Create(user2);
            var controller = GetUsersController(userRepository);
            var result = controller.Index(String.Empty) as ViewResult;
            var datamodel = (IEnumerable<User>)result.ViewData.Model;
            CollectionAssert.Contains(datamodel.ToList(), user1);
            CollectionAssert.Contains(datamodel.ToList(), user2);
        }

       
        User GetUserName(int id, string username, string name, string lastName, DateTime birthdate, decimal weight)
        {
            return new User
            {
                ID = id,
                LastName = lastName,
                Name = name,
                Birthdate = birthdate,
                Weight = weight
            };
        }

       
        [TestMethod]
        public void Create_PostUserInRepository()
        {
            FakeUserRepository userRepository = new FakeUserRepository();
            UsersController empcontroller = GetUsersController(userRepository);
            User User = GetUserID();
            empcontroller.Create(User);
            IEnumerable<User> Users = userRepository.GetAll();
            Assert.IsTrue(Users.Contains(User));
        }

        
        User GetUserID()
        {
            return GetUserName(1, "Prueba", "Prueba", "Prueba", DateTime.Now, 10);
        }

        
        [TestMethod]
        public void Create_PostRedirectOnSuccess()
        {
            UsersController controller = GetUsersController(new FakeUserRepository());
            User model = GetUserID();
            var result = (RedirectToRouteResult)controller.Create(model);
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

       
        [TestMethod]
        public void ViewIsNotValid()
        {
            UsersController empcontroller = GetUsersController(new FakeUserRepository());
            empcontroller.ModelState.AddModelError("", "mock error message");
            User model = GetUserName(1, "", "", "", DateTime.Now, 0);
            var result = (ViewResult)empcontroller.Create(model);
            Assert.AreEqual("Create", result.ViewName);
        }

    

        private class MockHttpContext : HttpContextBase
        {
            
        }
    }


}
