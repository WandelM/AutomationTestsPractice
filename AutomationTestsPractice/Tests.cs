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
            Logger.Log("Sign up page opened");
            Assert.That(PageFactory.GetPage<AuthenticationPage>().IsAt(), Is.True);
            PageFactory.GetPage<AuthenticationPage>().CreateAccount(DataGenerator.GenerateEmail(5));
            Logger.Log("Email inserted");
            PageFactory.GetPage<RegistrationPage>().TitleChoose(Titles.Mr);
            Logger.Log("Title chosen");
            PageFactory.GetPage<RegistrationPage>().InsertFirstName("Alan");
            Logger.Log("Name inserted");
            PageFactory.GetPage<RegistrationPage>().InsertLastName("Anderson");
            Logger.Log("Last name inserted");
            PageFactory.GetPage<RegistrationPage>().InsertPassword("Password1234!");
            Logger.Log("Password inserted");
            PageFactory.GetPage<RegistrationPage>().ChooseBirthDate(new DateTime(2000, 5, 10));
            Logger.Log("Birth date chosen");
            PageFactory.GetPage<RegistrationPage>().NewsletterSignIn();
            Logger.Log("Newsletter radio ticked");
            PageFactory.GetPage<RegistrationPage>().SpecialEventSignIn();
            Logger.Log("Signed in to special events");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
