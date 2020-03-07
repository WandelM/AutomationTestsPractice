using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestsFramework.Helpers
{
    public static class DataGenerator
    {
        /// <summary>
        /// Generates random email adress for @moakt.cc adresses
        /// </summary>
        /// <param name="prefixLength">length of email before @</param>
        /// <returns>Random email</returns>
        public static string GenerateEmail(int prefixLength)
        {
            var output = string.Empty;
            var sufix = "@moakt.cc";

            Random random = new Random();

            for (int i = 0; i < prefixLength; i++)
            {
                output += (char)random.Next('a', 'z');
            }

            output += sufix;

            return output;
        }
    }
}
