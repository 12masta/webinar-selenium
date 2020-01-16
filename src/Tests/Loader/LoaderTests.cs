using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.LoaderPage;

namespace Tests.Loader
{
    public class LoaderTests : BaseTest
    {
        [Test]
        public void LoaderTestsFailing()
        {
            //when
            var homePage = new LoaderPageFactory(driverWrapper, wait)
                .UnsafeLoad()
                .Create("/loader")
                .ClickBackToHome();

            //then
            homePage.Url().Should().Be(driverWrapper.BaseUrl + "/");
        }

        [Test]
        public void LoaderTestsPassing()
        {
            //when
            var homePage = new LoaderPageFactory(driverWrapper, wait)
                .Create("/loader")
                .ClickBackToHome();

            //then
            homePage.Url().Should().Be(driverWrapper.BaseUrl + "/");
        }
    }
}