using AutomationTestsFramework.PageObjects;
using AutomationTestsPractice.TestData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTestsPractice
{
    [TestFixture(Author ="MarcinW", Category = "Authorization", Description = "Authorization page tests")]
    class AuthenticationPageTests:BaseTest
    {
        [SetUp]
        public void TestSetUp()
        {
            PageFactory.GetPage<MainPage>().TopBar.SignUpPageOpen();
        }

        [TearDown]
        public void TestTearDown()
        {
            PageFactory.Driver.Navigate().GoToUrl(Configuration["AppUrl"]);
        }

        [TestCaseSource(typeof(AuthenticationData), nameof(AuthenticationData.WrongEmails))]
        public void AsAUserWhoHaveWrittenWrongEmailAddressIWantToSeeErrorMessage(string email)
        {
            var authenticationPage = PageFactory.GetPage<AuthenticationPage>();
            authenticationPage.CreateAccount(email);
            Assert.That(authenticationPage.ErrorMesseges.Count, Is.EqualTo(1));
            Assert.That(authenticationPage.ErrorMesseges.First(), Is.EqualTo("Invalid email address."));
        }

        [TestCaseSource(typeof(AuthenticationData), nameof(AuthenticationData.CorrectEmails))]
        public void AsAUserWhoHaveWrittenCorrectEmailIWantToBeRedirectedToRegisterForm(string email)
        {
            var authenticationPage = PageFactory.GetPage<AuthenticationPage>();
            authenticationPage.CreateAccount(email);
            var registrationPage = PageFactory.GetPage<RegistrationPage>();
            Assert.That(registrationPage.IsAt(), Is.True);
        }
    }
}
