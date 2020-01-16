using TestFramework.DriverWrapper;
using TestFramework.Dto;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TestFramework.Waits;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests
{
    public class BaseTest
    {
        protected IDriverWrapper driverWrapper;
        protected IWait wait;

        [SetUp]
        public void Setup()
        {
            var driverConfig = new DriverConfiguration()
                .Bind();
            driverWrapper = new DriverWrapper(new ChromeDriver(driverConfig.DriverPath), driverConfig);
            wait = new Wait(new WebDriverWait(driverWrapper.Driver, TimeSpan.FromSeconds(driverConfig.DefaultTimeout)), driverWrapper);
        }

        [TearDown]
        public void TearDown()
        {
            driverWrapper.Dispose();
        }
    }
}
