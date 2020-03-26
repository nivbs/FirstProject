using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Infrastructure
{
    public abstract class DriverUser
    {
        protected IWebDriver Driver { get; private set; }

        public DriverUser(IWebDriver driver)
        {
            Driver = driver;
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}