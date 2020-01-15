using System;
using TestFramework.Dto;
using OpenQA.Selenium;

namespace TestFramework.DriverWrapper
{
    public class DriverWrapper : IDriverWrapper, IDisposable
    {
        private IWebDriver webDriver;
        private DriverConfiguration driverConfiguration;

        public string BaseUrl => driverConfiguration.Url;

        public DriverWrapper(IWebDriver webDriver, DriverConfiguration driverConfiguration)
        {
            this.webDriver = webDriver;
            this.driverConfiguration = driverConfiguration;
        }

        public IDriverWrapper Load()
        {
            webDriver.Url = BaseUrl;
            return this;
        }

        public IDriverWrapper Load(string path)
        {
            webDriver.Url = BaseUrl + path;
            return this;
        }

        public void Dispose()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
            }
        }

        public string Url()
        {
            return webDriver.Url;
        }


    }
}