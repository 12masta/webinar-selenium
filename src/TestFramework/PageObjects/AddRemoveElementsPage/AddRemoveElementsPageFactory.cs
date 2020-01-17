using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace Tests.AddRemoveElementsPage
{
    public class AddRemoveElementsPageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private IWebElementComposer webElementComposer;

        private bool safeLoad = true;

        public AddRemoveElementsPageFactory(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public AddRemoveElementsPageFactory UnsafeLoad()
        {
            safeLoad = false;
            return this;
        }

        public IAddRemoveElementsPage Create()
        {
            if (safeLoad)
            {
                return new AddRemoveElementsPage(driverWrapper, wait, webElementComposer);
            }

            if (!safeLoad)
            {
                return new AddRemoveElementsPage(driverWrapper, wait, webElementComposer, safeLoad);
            }
            return new AddRemoveElementsPage(driverWrapper, wait, webElementComposer);

        }

        public IAddRemoveElementsPage Create(string path)
        {
            if (safeLoad)
            {
                return new AddRemoveElementsPage(driverWrapper, wait, webElementComposer, path);
            }

            if (!safeLoad)
            {
                return new AddRemoveElementsPage(driverWrapper, wait, webElementComposer, path, safeLoad);
            }

            return new AddRemoveElementsPage(driverWrapper, wait, webElementComposer, path);
        }
    }
}