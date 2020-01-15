namespace TestFramework.DriverWrapper
{
    public interface IDriverWrapper
    {
        string BaseUrl { get; }
        IDriverWrapper Load();
        IDriverWrapper Load(string path);
        string Url();
        void Dispose();
    }
}