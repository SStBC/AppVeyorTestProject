using System;
using AppVeyorTestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppVeyorTestProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var h = new Handler();
            var i = 4;
            Assert.AreEqual(i + 1, h.Increment(i));

        }
    }
}
