namespace Tests.DynamicConstrolsPage
{
    public interface IDynamicConstrolsPage
    {
        IDynamicConstrolsPage ClickRemove();
        string Url();
        IDynamicConstrolsPage ClickAdd();
        IDynamicConstrolsPage CheckCheckbox();
        bool IsCheckBoxSelected();
    }
}