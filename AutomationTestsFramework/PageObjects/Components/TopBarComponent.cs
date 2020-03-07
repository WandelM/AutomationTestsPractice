using OpenQA.Selenium;
using System;

namespace AutomationTestsFramework.PageObjects
{
    /// <summary>
    /// Page top bar (header)
    /// </summary>
    public class TopBarComponent
    {
        private IWebElement NavMenu { get; set; }

        public TopBarComponent(IWebElement navMenuElement)
        {
            NavMenu = navMenuElement;
        }

        private IWebElement SignUpButton => NavMenu.FindElement(By.XPath(".//div[@class='nav']//div[@class='header_user_info']"));
        private IWebElement ContactUsButton => NavMenu.FindElement(By.XPath(".//div[@class='nav']//div[@id='contact-link']"));
        private IWebElement SearchBar => NavMenu.FindElement(By.XPath(".//input[@name='search_query']"));
        private IWebElement ShoppingCart => NavMenu.FindElement(By.XPath(".//a[@title='View my shopping cart']"));

        public void SignUpPageOpen()
        {
            SignUpButton.Click();
        }

        public void ContactUsPageOpen()
        {
            ContactUsButton.Click();
        }

        public void SearchForProduct(string productName)
        {
            if (!string.IsNullOrEmpty(productName))
            {
                SearchBar.SendKeys(productName);
                SearchBar.Submit();
            }
            else
            {
                throw new ArgumentException("Phrase can not be empty", nameof(productName));
            }
        }

        public void ShoppingCartOpen()
        {
            ShoppingCart.Click();
        }
    }
}