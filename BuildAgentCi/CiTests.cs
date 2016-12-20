using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace BuildAgentCi
{
    [TestFixture]
    public class CiTests
    {
        private IWebDriver _webDriver;

        [TearDown]
        public void RunAfterAnyTests()
        {
            _webDriver.Quit();
        }

        [Test]
        public void TestMethod1()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl("http://google.com");
            Assert.AreEqual("Fake Google", _webDriver.Title);
        }
    }
}
