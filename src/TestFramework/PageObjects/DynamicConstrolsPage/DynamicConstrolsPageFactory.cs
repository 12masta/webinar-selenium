using TestFramework.DriverWrapper;
using TestFramework.Waits;

namespace Tests.DynamicConstrolsPage
{
    public class DynamicConstrolsPageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;

        private bool safeLoad = true;

        public DynamicConstrolsPageFactory(IDriverWrapper driverWrapper, IWait wait)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
        }

        public DynamicConstrolsPageFactory UnsafeLoad()
        {
            safeLoad = false;
            return this;
        }

        public IDynamicConstrolsPage Create()
        {
            if (safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait);
            }

            if (!safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait, safeLoad);
            }
            return new DynamicConstrolsPage(driverWrapper, wait);

        }

        public IDynamicConstrolsPage Create(string path)
        {
            if (safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait, path);
            }

            if (!safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait, path, safeLoad);
            }

            return new DynamicConstrolsPage(driverWrapper, wait, path);
        }
    }
}