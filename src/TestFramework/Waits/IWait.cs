using OpenQA.Selenium;

namespace TestFramework.Waits
{
    public interface IWait
    {
        IWait UntilElementIsNotDisplayed(IWebElement loaderWrapper);
    }
}