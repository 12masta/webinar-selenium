using TestFramework.DriverWrapper;
using TestFramework.Dto;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BaseTest
    {
        protected IDriverWrapper driverWrapper;

        [SetUp]
        public void Setup()
        {
            var driverConfig = new DriverConfiguration()
                .Bind();
            driverWrapper = new DriverWrapper(new ChromeDriver(driverConfig.DriverPath), driverConfig);
        }

        [TearDown]
        public void TearDown()
        {
            driverWrapper.Dispose();
        }
    }
}
