using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualPush.WebAPI;
using VisualPush.WebAPI.Controllers;

namespace VisualPush.WebAPI.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            //// Arrange
            //NotificationController controller = new NotificationController();

            //// Act
            //IEnumerable<string> result = controller.Get();

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            //// Arrange
            //NotificationController controller = new NotificationController();

            //// Act
            //string result = controller.Get(5);

            //// Assert
            //Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            //// Arrange
            //NotificationController controller = new NotificationController();

            //// Act
            //controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            //// Arrange
            //NotificationController controller = new NotificationController();

            //// Act
            //controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            //// Arrange
            //NotificationController controller = new NotificationController();

            //// Act
            //controller.Delete(5);

            // Assert
        }
    }
}
