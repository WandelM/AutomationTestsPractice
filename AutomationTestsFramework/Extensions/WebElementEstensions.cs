using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Text;

namespace AutomationTestsFramework.Extensions
{
    public static class WebElementEstensions
    {
        /// <summary>
        /// Inserts or edit text in textbox
        /// </summary>
        /// <param name="textboxElement">TextBox where text has to be inserted</param>
        /// <param name="textToBeInserted">Inserted text</param>
        public static void InsertOrEdit(this IWebElement textboxElement, string textToBeInserted)
        {
            var elementTag = textboxElement.TagName;
            var elementTypeAttribiute = textboxElement.GetAttribute("type");

            if (elementTag == "input" && (elementTypeAttribiute == "text" || elementTypeAttribiute == "password"))
            {
                if (!string.IsNullOrEmpty(textboxElement.Text))
                {
                    textboxElement.SendKeys(textToBeInserted);
                }
                else
                {
                    textboxElement.Clear();
                    textboxElement.SendKeys(textToBeInserted);
                }
            }
            else
            {
                throw new Exception("IWebElement has to be input type and has to have type attribute set to text");
            }
        }
    }
}
