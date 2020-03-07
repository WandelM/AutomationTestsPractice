using OpenQA.Selenium;
using PageFactoryCore;

namespace AutomationTestsFramework.PageObjects
{
    public abstract class BasePage : IPage
    {
        public IWebDriver Driver { get; set; }

        public TopBarComponent TopBar => new TopBarComponent(Driver.FindElement(By.XPath("//header[@id='header']")));
    }
}
