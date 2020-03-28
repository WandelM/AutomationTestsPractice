using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestsFramework.Logger
{
    public class ConsoleLogger : ILoger
    {
        public void Log(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
