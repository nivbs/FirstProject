using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class BasePage : DriverUser
    {
        public BasePage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}