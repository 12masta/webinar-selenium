using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using Tests.DynamicConstrolsPage;

namespace Tests.StaleElementRefException
{
    public class StaleElementRefExceptionTests : BaseTest
    {
        [Test]
        public void StaleElementRefExceptionFailing()
        {
            //load dynamic_controls
            driverWrapper.Load("/dynamic_controls");

            //check checkbox
            var checkboxInput = driverWrapper.FindElement(By.XPath("//*[@data-automation='checkbox-input']"));
            checkboxInput.Click();

            //click remove button
            driverWrapper.FindElement(By.XPath("//*[@data-automation='remove-add-button']")).Click();
            wait.UntilElementIsNotDisplayed(driverWrapper.FindElement(By.XPath("//*[@data-automation='loading']")));

            //click add button
            driverWrapper.FindElement(By.XPath("//*[@data-automation='remove-add-button']")).Click();
            wait.UntilElementIsNotDisplayed(driverWrapper.FindElement(By.XPath("//*[@data-automation='loading']")));

            //check checkbox
            checkboxInput.Click();

            //is checkbox Selected - not reachable
            checkboxInput.Selected.Should().BeTrue();
        }

        [Test]
        public void StaleElementRefExceptionPassing()
        {
            //when
            var dynamicControlsPage = new DynamicConstrolsPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/dynamic_controls")
                .CheckCheckbox()
                .ClickRemove()
                .ClickAdd()
                .CheckCheckbox();

            //then
            dynamicControlsPage.IsCheckBoxSelected().Should().BeTrue();
        }
    }
}