using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTestsFramework.PageObjects
{
    public class AuthenticationPage:BasePage
    {
        private IWebElement CreateAccountBox => Driver.FindElement(By.Id("create-account_form"));
        private IWebElement CreateAccountEmailInput => CreateAccountBox.FindElement(By.XPath(".//input[@id='email_create']"));
        private IWebElement CreateAccountButton => CreateAccountBox.FindElement(By.XPath(".//button[@id='SubmitCreate']"));
        public IReadOnlyCollection<string> ErrorMesseges => CreateAccountBox.FindElements(By.XPath(".//*[@id='create_account_error']/ol//li")).Select(e => e.Text).ToList().AsReadOnly();

        /// <summary>
        /// Checking if user is on authentication page
        /// </summary>
        /// <returns></returns>
        public bool IsAt()
        {
            var pageUrl = Driver.Url.ToLower();
            var pageTitle = Driver.Title.ToLower();

            return pageUrl.Contains("authentication") && pageTitle.Contains("login");
        }

        public void CreateAccount(string email)
        {
            CreateAccountEmailInput.SendKeys(email);
            CreateAccountButton.Click();
        }
    }
}
