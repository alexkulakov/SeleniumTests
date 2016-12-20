using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

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
            PageObject1 page = new PageObject1();
            PageFactory.InitElements(_webDriver, page);
            
            _webDriver.Navigate().GoToUrl("http://google.com");
            Assert.AreEqual("Fake Google", page.Btn.GetAttribute("value"));
            //Assert.AreEqual("Fake Google", page.Container[0].GetAttribute("value"));
            //Assert.AreEqual("Fake Google", _webDriver.Title);
        }
    }
}
