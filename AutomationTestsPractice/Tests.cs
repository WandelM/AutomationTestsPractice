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
            System.Threading.Thread.Sleep(1000);
        }
    }
}
