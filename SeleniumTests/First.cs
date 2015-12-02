using OpenQA.Selenium;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class First
    {
        private IWebDriver _webDriver;

        //[TestCleanup]
        //public void TestCleanup()
        [TearDown]
        public void RunAfterAnyTests()
        { 
            _webDriver.Quit();
        }

        //[TestMethod]
        [Test]
        public void TestMethod1()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl("http://google.com");
            Assert.AreEqual("Fake Google", _webDriver.Title);
        }
    }
}
