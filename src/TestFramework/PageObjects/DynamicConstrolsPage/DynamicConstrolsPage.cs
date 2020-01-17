using System;
using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using TestFramework.Element;
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
        private IWebElementComposer webElementComposer;

        public DynamicConstrolsPage(IDriverWrapper driverWrapper,
                                    IWait wait,
                                    IWebElementComposer webElementComposer,
                                    bool safeLoad = true) : base(driverWrapper)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public DynamicConstrolsPage(IDriverWrapper driverWrapper,
                                    IWait wait,
                                    IWebElementComposer webElementComposer,
                                    string path,
                                    bool safeLoad = true) : base(driverWrapper, path)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public IDynamicConstrolsPage ClickRemove()
        {
            wait.UntilElementIsNotDisplayed(LoaderBy, TimeSpan.FromSeconds(10));
            RemoveAddButton.Click();
            return this;
        }

        public IDynamicConstrolsPage ClickAdd()
        {
            wait.UntilElementIsNotDisplayed(LoaderBy, TimeSpan.FromSeconds(10));
            RemoveAddButton.Click();
            return this;
        }

        public IDynamicConstrolsPage CheckCheckbox()
        {
            wait.UntilElementIsNotDisplayed(LoaderBy, TimeSpan.FromSeconds(10));
            CheckboxInput.Click();
            return this;
        }

        public bool IsCheckBoxSelected()
        {
            return CheckboxInput.Selected;
        }
    }
}