using TestFramework.DriverWrapper;
using TestFramework.PageObjects.HomePage;
using OpenQA.Selenium;
using TestFramework.Waits;

namespace TestFramework.PageObjects.LoaderPage
{
    public class LoaderPage : BasePageObject, ILoaderPage
    {
        private IWebElement BackToHomeButton
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//*[@data-automation='back-to-home-button']"));
            }
        }

        private IWebElement LoaderWrapper
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//*[@data-automation='loader-wrapper']"));
            }
        }

        public LoaderPage(IDriverWrapper driverWrapper, IWait wait, bool safeLoad = true) : base(driverWrapper)
        {
            if (safeLoad)
            {
                wait.UntilElementIsNotDisplayed(LoaderWrapper);
            }
        }

        public LoaderPage(IDriverWrapper driverWrapper, IWait wait, string path, bool safeLoad = true) : base(driverWrapper, path)
        {
            if (safeLoad)
            {
                wait.UntilElementIsNotDisplayed(LoaderWrapper);
            }
        }

        public IHomePage ClickBackToHome()
        {
            BackToHomeButton.Click();
            return new HomePageFactory(driverWrapper).Create();
        }
    }
}