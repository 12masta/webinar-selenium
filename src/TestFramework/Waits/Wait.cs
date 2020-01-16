using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFramework.DriverWrapper;

namespace TestFramework.Waits
{
    public class Wait : IWait
    {
        private WebDriverWait webDriverWait;
        private IDriverWrapper driverWrapper;

        public Wait(WebDriverWait webDriverWait, IDriverWrapper driverWrapper)
        {
            this.webDriverWait = webDriverWait;
            this.driverWrapper = driverWrapper;
        }

        public IWait UntilElementIsNotDisplayed(IWebElement loaderWrapper)
        {
            webDriverWait.Until(_ => loaderWrapper.Displayed == false);
            return this;
        }

        public IWait UntilElementIsNotDisplayed(By loaderBy)
        {
            webDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            webDriverWait.IgnoreExceptionTypes(typeof(WebDriverTimeoutException));
            webDriverWait.Timeout = TimeSpan.FromSeconds(3);
            try
            {
                webDriverWait.Until(_ => driverWrapper.FindElement(loaderBy).Displayed == false);
            }
            catch (WebDriverTimeoutException)
            {
                return this;
            }

            return this;
        }
    }
}