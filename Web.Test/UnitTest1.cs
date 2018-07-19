﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Web.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
