using AutomationTestsFramework.Helpers;
using AutomationTestsFramework.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestsPractice
{
    [TestFixture]
    public class Tests:BaseTest
    {
        [Test]
        public void test()
        {
            PageFactory.GetPage<MainPage>().TopBar.SignUpPageOpen();
            Assert.That(PageFactory.GetPage<AuthenticationPage>().IsAt(), Is.True);
            PageFactory.GetPage<AuthenticationPage>().CreateAccount(DataGenerator.GenerateEmail(5));
            PageFactory.GetPage<RegistrationPage>().TitleChoose(Titles.Mr);
            PageFactory.GetPage<RegistrationPage>().InsertFirstName("Alan");
            PageFactory.GetPage<RegistrationPage>().InsertLastName("Anderson");
            PageFactory.GetPage<RegistrationPage>().InsertPassword("Password1234!");
            PageFactory.GetPage<RegistrationPage>().ChooseBirthDate(new DateTime(2000, 5, 10));
            PageFactory.GetPage<RegistrationPage>().NewsletterSignIn();
            PageFactory.GetPage<RegistrationPage>().SpecialEventSignIn();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
