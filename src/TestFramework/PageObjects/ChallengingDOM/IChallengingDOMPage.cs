using System.Collections.Generic;
using OpenQA.Selenium;

namespace TestFramework.PageObjects.ChallengingDOM
{
    public interface IChallengingDOMPage
    {
        string Url();
        IWebElement GetButton();
        IWebElement GetButtonAlert();
        IWebElement GetButtonSuccess();
        IWebElement GetButtonNasty();
        IWebElement GetButtonAlertNasty();
        IWebElement GetButtonSuccessNasty();
        IList<IWebElement> GetTableRows();
        IList<IWebElement> GetTableRowsNasty();
        string GetTableSitCellValue(int v);
        string GetTableSitCellValueNasty(int v);
        IWebElement GetEditLink(int v);
        IWebElement GetEditLinkNasty(int v);
    }
}