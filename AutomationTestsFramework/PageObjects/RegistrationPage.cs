using OpenQA.Selenium;
using System;
using AutomationTestsFramework.Extensions;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestsFramework.PageObjects
{
    public class RegistrationPage:BasePage 
    {
        private IWebElement MrRadioButton => Driver.FindElement(By.XPath("//input[@id='id_gender1']"));
        private IWebElement MrsRadioButton => Driver.FindElement(By.XPath("//input[@id='id_gender2']"));
        private IWebElement FirstNameTxtBox => Driver.FindElement(By.XPath("//input[@id='customer_firstname']"));
        private IWebElement LastNameTxtBox => Driver.FindElement(By.XPath("//input[@id='customer_lastname']"));
        private IWebElement EmailTxtBox => Driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement PasswordTxtBox => Driver.FindElement(By.XPath("//input[@id='passwd']"));
        private IWebElement DayDropDown => Driver.FindElement(By.XPath("//select[@id='days']"));
        private IWebElement MonthDropDown => Driver.FindElement(By.XPath("//select[@id='months']"));
        private IWebElement YearDropDown => Driver.FindElement(By.XPath("//select[@id='years']"));
        private IWebElement NewsletterCheckBox => Driver.FindElement(By.XPath("//input[@id='newsletter']"));
        private IWebElement SpecialOffersCheckBox => Driver.FindElement(By.XPath("//input[@id='optin']"));

        public void TitleChoose(Titles title)
        {
            switch (title)
            {
                case Titles.Mr:
                    MrRadioButton.Click();
                    break;
                case Titles.Mrs:
                    MrsRadioButton.Click();
                    break;
                default:
                    MrRadioButton.Click();
                    break;
            }
        }
        public void InsertFirstName(string firstName) => FirstNameTxtBox.InsertOrEdit(firstName);
        public void InsertLastName(string lastName) => LastNameTxtBox.InsertOrEdit(lastName);
        public void InsertEmail(string email) => EmailTxtBox.InsertOrEdit(email);
        public void InsertPassword(string password) => PasswordTxtBox.InsertOrEdit(password);
        public void ChooseBirthDate(DateTime date)
        {
            SelectElement daySelect = new SelectElement(DayDropDown);
            SelectElement monthSelect = new SelectElement(MonthDropDown);
            SelectElement yearSelect = new SelectElement(YearDropDown);

            daySelect.SelectByValue(date.Day.ToString());
            monthSelect.SelectByValue(date.Month.ToString());
            yearSelect.SelectByValue(date.Year.ToString());
        }
        public void NewsletterSignIn() => NewsletterCheckBox.Click();
        public void SpecialEventSignIn() => SpecialOffersCheckBox.Click();
    }
}
