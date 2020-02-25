using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.ChallengingDOM;

namespace Tests.TestautomationAttributes
{
    public class TestAutomationAttributeButtonExampleTests : BaseTest
    {
        [Test]
        public void Button_should_not_be_null()
        {
            var button = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetButton();

            button.Should().NotBeNull();
        }

        [Test]
        public void Button_should_not_be_null_nasty()
        {
            var button = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetButtonNasty();

            button.Should().NotBeNull();
        }

        [Test]
        public void Button_alert_should_not_be_null()
        {
            var button = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetButtonAlert();

            button.Should().NotBeNull();
        }

        [Test]
        public void Button_alert_should_not_be_null_nasty()
        {
            var button = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetButtonAlertNasty();

            button.Should().NotBeNull();
        }

        [Test]
        public void Button_success_should_not_be_null()
        {
            var button = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetButtonSuccess();

            button.Should().NotBeNull();
        }

                [Test]
        public void Button_success_should_not_be_null_nasty()
        {
            var button = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetButtonSuccessNasty();

            button.Should().NotBeNull();
        }
    }
}