using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure.Extensions
{
    public static class IWebElementExtensions
    {
        public static void ClearAndSendKeys(this IWebElement webElement, string value)
        {
            webElement.Clear();
            webElement.SendKeys(value);
        }
    }
}
