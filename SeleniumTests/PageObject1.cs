using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTests
{
    public sealed class PageObject1
    {
        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement Btn;
        /*
        [FindsBy(How = How.Name, Using = "btnK")]
        public IList<PageObject2> Container;
        */
        public PageObject1()
        { }
    }

    public sealed class PageObject2 : IWrapsElement
    {
        public IWebElement WrappedElement { get; }
    }

    public class CommonPageObject : IWrapsElement
    {
        public IWebElement WrappedElement { get; }

        private IElementLocator _locator;

        protected CommonPageObject(IElementLocator locator)
        {
            _locator = locator;
        }
    }

    internal abstract class MyWebDriverObjectProxy
    {
        private readonly IElementLocator _locator;
        private readonly IEnumerable<By> _bys;

        internal MyWebDriverObjectProxy(IElementLocator locator, IEnumerable<By> bys)
        {
            _locator = locator;
            _bys = bys;
        }
    }
}
