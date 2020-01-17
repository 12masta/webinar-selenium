using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace Tests.DynamicConstrolsPage
{
    public class DynamicConstrolsPageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private IWebElementComposer webElementComposer;

        private bool safeLoad = true;

        public DynamicConstrolsPageFactory(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
            this.webElementComposer = webElementComposer;
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
                return new DynamicConstrolsPage(driverWrapper, wait, webElementComposer);
            }

            if (!safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait, webElementComposer, safeLoad);
            }
            return new DynamicConstrolsPage(driverWrapper, wait, webElementComposer);

        }

        public IDynamicConstrolsPage Create(string path)
        {
            if (safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait, webElementComposer, path);
            }

            if (!safeLoad)
            {
                return new DynamicConstrolsPage(driverWrapper, wait, webElementComposer, path, safeLoad);
            }

            return new DynamicConstrolsPage(driverWrapper, wait, webElementComposer, path);
        }
    }
}