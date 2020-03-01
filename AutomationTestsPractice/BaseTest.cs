using AutomationTestsFramework.Core;
using NUnit.Framework;
using PageFactoryCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace AutomationTestsPractice
{
    [TestFixture]
    public class BaseTest
    {
        public PageFactory PageFactory { get; private set; }
        public IConfiguration Configuration { get; private set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            Configuration = builder.AddJsonFile("testConfig.json").Build();
           
            var driver = DriverFactory.GetDriverInstance(Browsers.chrome, Configuration["appUrl"]);
            PageFactory = new PageFactory(driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            PageFactory.Driver.Close();
        }
    }
}
