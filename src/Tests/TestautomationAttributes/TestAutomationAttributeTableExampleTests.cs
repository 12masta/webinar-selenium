using FluentAssertions;
using NUnit.Framework;
using TestFramework.PageObjects.ChallengingDOM;

namespace Tests.TestautomationAttributes
{
    public class TestAutomationAttributeTableExampleTests : BaseTest
    {
        [Test]
        public void Get_table_rows()
        {
            var rows = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetTableRows();

            rows.Should().NotBeNull().And.HaveCount(10);
        }

        [Test]
        public void Get_table_rows_nasty()
        {
            var rows = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetTableRowsNasty();

            rows.Should().NotBeNull().And.HaveCount(10);
        }

        [Test]
        public void Get_value_from_6_row_and_sit_column()
        {
            var cellValue = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetTableSitCellValue(6);

            cellValue.Should().Be("Definiebas6");
        }

        [Test]
        public void Get_value_from_6_row_and_sit_column_nasty()
        {
            var cellValue = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetTableSitCellValueNasty(6);

            cellValue.Should().Be("Definiebas6");
        }
        
        [Test]
        public void Get_edit_link_from_6_row()
        {
            var editLink = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetEditLink(6);

            editLink.Should().NotBeNull();
            editLink.Text.Should().Be("edit");
        }

        [Test]
        public void Get_edit_link_from_6_row_nasty()
        {
            var editLink = new ChallengingDOMPageFactory(driverWrapper, wait, webElementComposer)
                .Create("/challenging_dom")
                .GetEditLinkNasty(6);

            editLink.Should().NotBeNull();
            editLink.Text.Should().Be("edit");
        }
    }
}