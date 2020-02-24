using System;
using OpenQA.Selenium;
using TestFramework.DriverWrapper;

namespace TestFramework.Highliters
{
    public class Highliter : IHighliter
    {
        private IDriverWrapper driverWrapper;
        private IWebElement lastHighlightedElement;

        public Highliter(IDriverWrapper driverWrapper)
        {
            this.driverWrapper = driverWrapper;
        }

        public IHighliter HighlightElement(IWebElement webElement)
        {
            UnHighlightElementBase(lastHighlightedElement);
            HighlightElementBase(webElement);
            lastHighlightedElement = webElement;
            return this;
        }

        public IHighliter HighlightElementBase(IWebElement webElement)
        {
            try
            {
                ((IJavaScriptExecutor)driverWrapper.Driver).ExecuteScript("arguments[0].setAttribute('style','border: 2px solid red;');", webElement);
            }
            catch (Exception)
            {
                //some loogging in case of failure
                return this;
            }

            return this;
        }

        public IHighliter UnHighlightElementBase(IWebElement webElement)
        {
            if (webElement != null)
            {
                try
                {
                    ((IJavaScriptExecutor)driverWrapper.Driver).ExecuteScript("arguments[0].setAttribute('style','border: 0px solid red;');", webElement);
                }
                catch (Exception)
                {
                    //some loogging in case of failure
                    return this;
                }
            }

            return this;
        }
    }
}