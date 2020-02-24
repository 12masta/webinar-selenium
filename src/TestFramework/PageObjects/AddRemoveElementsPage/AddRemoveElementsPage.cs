using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.PageObjects;
using TestFramework.Waits;

namespace Tests.AddRemoveElementsPage
{
    public class AddRemoveElementsPage : BasePageObject, IAddRemoveElementsPage
    {

        private IWebElement AddElementButton
        {
            get => driverWrapper.FindElement(By.XPath("//*[@data-automation='add-element-button']"));
        }

        private IList<IWebElement> RemoveButtons
        {
            get => driverWrapper.FindElements(By.XPath("//*[contains(@data-automation, 'delete-button')]"));
        }

        private IWait wait;
        private IWebElementComposer webElementComposer;

        public AddRemoveElementsPage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, bool safeLoad = true) : base(driverWrapper)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public AddRemoveElementsPage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, string path, bool safeLoad = true) : base(driverWrapper, path)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public IAddRemoveElementsPage ClickAddElementButton()
        {
            webElementComposer.Click(AddElementButton);
            return this;
        }

        public int NumberOfDeleteButtons()
        {
            return RemoveButtons.Count;
        }

        public IAddRemoveElementsPage ClickRemoveButton(int v)
        {
            webElementComposer.Click(RemoveButtons.ElementAtOrDefault(v));
            return this;
        }
    }
}