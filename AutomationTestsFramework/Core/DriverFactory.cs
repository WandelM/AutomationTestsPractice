using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace AutomationTestsFramework.Core
{
    /// <summary>
    /// Browsers that can be opened
    /// </summary>
    public enum Browsers
    {
        edge,
        chrome,
        firefox
    }

    /// <summary>
    /// Factory for web driver
    /// </summary>
    public static class DriverFactory
    {
        /// <summary>
        /// Returns new wweb driver instance
        /// </summary>
        /// <param name="browser">Browser that has to be opened</param>
        /// <returns>Web driver instance</returns>
        public static IWebDriver GetDriverInstance(Browsers browser, int waitTime)
        {
            IWebDriver driver;

            switch (browser)
            {
                case Browsers.edge:
                    driver = new EdgeDriver();
                    break;
                case Browsers.chrome:
                    driver = new ChromeDriver();
                    break;
                case Browsers.firefox:
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTime);

            return driver;
        }

        /// <summary>
        /// Opens new browser
        /// </summary>
        /// <param name="browser">Browser that has to be opened</param>
        /// <param name="url">Url of web application</param>
        /// <returns>New web driver instance</returns>
        public static IWebDriver GetDriverInstance(Browsers browser, string url, int waitTime)
        {
            var driverInstance = GetDriverInstance(browser, waitTime);

            driverInstance.Navigate().GoToUrl(url);

            return driverInstance;
        }
    }
}
