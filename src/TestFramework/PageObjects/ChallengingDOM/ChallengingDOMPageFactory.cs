using TestFramework.DriverWrapper;
using TestFramework.Element;
using TestFramework.Waits;

namespace TestFramework.PageObjects.ChallengingDOM
{
    public class ChallengingDOMPageFactory
    {
        private IDriverWrapper driverWrapper;
        private IWait wait;
        private IWebElementComposer webElementComposer;

        private bool safeLoad = true;
        
        public ChallengingDOMPageFactory(IDriverWrapper driverWrapper, IWait wait, IWebElementComposer webElementComposer)
        {
            this.driverWrapper = driverWrapper;
            this.wait = wait;
            this.webElementComposer = webElementComposer;
        }

        public ChallengingDOMPageFactory UnsafeLoad()
        {
            safeLoad = false;
            return this;
        }

        public IChallengingDOMPage Create()
        {
            if (safeLoad)
            {
                return new ChallengingDOMPage(driverWrapper, wait, webElementComposer);
            }

            if (!safeLoad)
            {
                return new ChallengingDOMPage(driverWrapper, wait, webElementComposer, safeLoad);
            }
            return new ChallengingDOMPage(driverWrapper, wait, webElementComposer);

        }

        public IChallengingDOMPage Create(string path)
        {
            if (safeLoad)
            {
                return new ChallengingDOMPage(driverWrapper, wait, webElementComposer, path);
            }

            if (!safeLoad)
            {
                return new ChallengingDOMPage(driverWrapper, wait, webElementComposer, path, safeLoad);
            }

            return new ChallengingDOMPage(driverWrapper, wait, webElementComposer, path);
        }
    }
}