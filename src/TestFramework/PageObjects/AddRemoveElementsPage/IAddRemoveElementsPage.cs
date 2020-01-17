namespace Tests.AddRemoveElementsPage
{
    public interface IAddRemoveElementsPage
    {
        IAddRemoveElementsPage ClickAddElementButton();
        int NumberOfDeleteButtons();
        IAddRemoveElementsPage ClickRemoveButton(int v);
    }
}