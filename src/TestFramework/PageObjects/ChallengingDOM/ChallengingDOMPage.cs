using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace TestFramework.PageObjects.ChallengingDOM
{
    public class ChallengingDOMPage : BasePageObject, IChallengingDOMPage
    {

        private IWebElement Button
        {
            get => driverWrapper.FindElement(By.XPath("//*[@data-automation='button']"));
        }

        private IWebElement ButtonNasty
        {
            get => driverWrapper.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[1]"));
        }

        private IWebElement ButtonAlert
        {
            get => driverWrapper.FindElement(By.XPath("//*[@data-automation='button-alert']"));
        }

        private IWebElement ButtonAlertNasty
        {
            get => driverWrapper.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[2]"));
        }

        private IWebElement ButtonSuccess
        {
            get => driverWrapper.FindElement(By.XPath("//*[@data-automation='button-success']"));
        }

        private IWebElement ButtonSuccessNasty
        {
            get => driverWrapper.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[1]/a[3]"));
        }

        private IList<IWebElement> TableRows
        {
            get => driverWrapper.FindElements(By.XPath("//*[@data-automation='table-row-body']"));
        }

        private IList<IWebElement> TableRowsNasty
        {
            get => driverWrapper.FindElement(By.TagName("table")).FindElement(By.TagName("tbody")).FindElements(By.TagName("tr"));
        }

        private IWait wait;
        private IWebElementComposer webElementComposer;

        public ChallengingDOMPage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, bool safeLoad = true) : base(driverWrapper)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public ChallengingDOMPage(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer, string path, bool safeLoad = true) : base(driverWrapper, path)
        {
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public IWebElement GetButton()
        {
            return Button;
        }

        public IWebElement GetButtonAlert()
        {
            return ButtonAlert;
        }

        public IWebElement GetButtonSuccess()
        {
            return ButtonSuccess;
        }

        public IWebElement GetButtonNasty()
        {
            return ButtonNasty;
        }

        public IWebElement GetButtonAlertNasty()
        {
            return ButtonAlertNasty;
        }

        public IWebElement GetButtonSuccessNasty()
        {
            return ButtonSuccessNasty;
        }

        public IList<IWebElement> GetTableRows()
        {
           return TableRows;
        }

        public IList<IWebElement> GetTableRowsNasty()
        {
            return TableRowsNasty;
        }

        public string GetTableSitCellValue(int v)
        {
            return TableRows.ElementAtOrDefault(v)
                .FindElement(By.XPath(".//*[@data-automation='table-row-body-sit']"))
                .Text;
        }

        public string GetTableSitCellValueNasty(int v)
        {
            return TableRowsNasty.ElementAtOrDefault(v)
                .FindElements(By.TagName("td"))
                .ElementAtOrDefault(3)
                .Text;
        }

        public IWebElement GetEditLink(int v)
        {
            return TableRows.ElementAtOrDefault(v)
                .FindElement(By.XPath(".//*[@data-automation='table-row-body-edit']"));
        }

        public IWebElement GetEditLinkNasty(int v)
        {
            return TableRowsNasty.ElementAtOrDefault(v)
                .FindElements(By.TagName("td"))
                .ElementAtOrDefault(6)
                .FindElements(By.TagName("a"))
                .ElementAtOrDefault(0);
        }
    }
}