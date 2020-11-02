using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestsPractice.TestData
{
    class AuthenticationData
    {
        public static IEnumerable<TestCaseData> WrongEmails
        {
            get
            {
                yield return new TestCaseData("email@email@com");
                yield return new TestCaseData("email.gmail.com");
                yield return new TestCaseData("andrut@gmail");
            }
        }

        public static IEnumerable<TestCaseData> CorrectEmails
        {
            get
            {
                yield return new TestCaseData("alabama@moakt.cc");
                yield return new TestCaseData("arnoldzik.flus@moakt.cc");
                yield return new TestCaseData("aster+long@gmail.com");
            }
        }
    }
}
