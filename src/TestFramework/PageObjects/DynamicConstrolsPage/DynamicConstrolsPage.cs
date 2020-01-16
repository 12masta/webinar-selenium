using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using TestFramework.PageObjects;
using TestFramework.Waits;

namespace Tests.DynamicConstrolsPage
{
    public class DynamicConstrolsPage : BasePageObject, IDynamicConstrolsPage
    {
        private IWebElement RemoveAddButton
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//*[@data-automation='remove-add-button']"));
            }
        }

        private By LoaderBy
        {
            get
            {
                return By.XPath("//*[@data-automation='loading']");
            }
        }

        private IWebElement Loader
        {
            get
            {
                return driverWrapper.FindElement(LoaderBy);
            }
        }

        private IWebElement CheckboxInput
        {
            get
            {
                return driverWrapper.FindElement(By.XPath("//*[@data-automation='checkbox-input']"));
            }
        }

        private IWait wait;

        public DynamicConstrolsPage(IDriverWrapper driverWrapper, IWait wait, bool safeLoad = true) : base(driverWrapper)
        {
            this.wait = wait;
        }

        public DynamicConstrolsPage(IDriverWrapper driverWrapper, IWait wait, string path, bool safeLoad = true) : base(driverWrapper, path)
        {
            this.wait = wait;
        }

        public IDynamicConstrolsPage ClickRemove()
        {
            wait.UntilElementIsNotDisplayed(LoaderBy);
            RemoveAddButton.Click();
            return this;
        }

        public IDynamicConstrolsPage ClickAdd()
        {
            wait.UntilElementIsNotDisplayed(LoaderBy);
            RemoveAddButton.Click();
            return this;
        }

        public IDynamicConstrolsPage CheckCheckbox()
        {
            wait.UntilElementIsNotDisplayed(LoaderBy);
            CheckboxInput.Click();
            return this;
        }

        public bool IsCheckBoxSelected()
        {
            return CheckboxInput.Selected;
        }
    }
}