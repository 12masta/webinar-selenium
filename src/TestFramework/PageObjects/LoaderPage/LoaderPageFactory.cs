using TestFramework.DriverWrapper;
using TestFramework.Waits;

namespace TestFramework.PageObjects.LoaderPage
{
    public class LoaderPageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private bool safeLoad = true;

        public LoaderPageFactory(IDriverWrapper driverWrapper, IWait wait)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
        }

        public LoaderPageFactory UnsafeLoad()
        {
            safeLoad = false;
            return this;
        }

        public ILoaderPage Create()
        {
            if (safeLoad)
            {
                return new LoaderPage(driverWrapper, wait);
            }

            if (!safeLoad)
            {
                return new LoaderPage(driverWrapper, wait, safeLoad);
            }
            return new LoaderPage(driverWrapper, wait);

        }

        public ILoaderPage Create(string path)
        {
            if (safeLoad)
            {
                return new LoaderPage(driverWrapper, wait, path);
            }

            if (!safeLoad)
            {
                return new LoaderPage(driverWrapper, wait, path, safeLoad);
            }

            return new LoaderPage(driverWrapper, wait, path);
        }
    }
}