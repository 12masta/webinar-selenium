using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestFramework.Waits
{
    public class Wait : IWait
    {
        private WebDriverWait webDriverWait;

        public Wait(WebDriverWait webDriverWait)
        {
            this.webDriverWait = webDriverWait;
        }

        public IWait UntilElementIsNotDisplayed(IWebElement loaderWrapper)
        {
            webDriverWait.Until(_ => loaderWrapper.Displayed == false);
            return this;
        }
    }
}