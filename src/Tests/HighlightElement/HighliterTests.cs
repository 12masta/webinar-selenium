using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.LoaderPage;
using Tests.AddRemoveElementsPage;

namespace Tests.HighlightElement
{
    public class HighliterTests : BaseTest
    {
        [Test]
        public void HighliterTest()
        {
            var addRemoveElementsPage = new AddRemoveElementsPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/add_remove_elements/")
                .ClickAddElementButton()
                .ClickAddElementButton()
                .ClickAddElementButton()
                .ClickAddElementButton()
                .ClickRemoveButton(2)
                .ClickAddElementButton()
                .ClickAddElementButton()
                .ClickRemoveButton(3);

            addRemoveElementsPage.NumberOfDeleteButtons().Should().Be(4);
        }
    }
}