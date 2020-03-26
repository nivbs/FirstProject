using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public abstract class BasePage : DriverUser
    {
        public Cart Cart => new Cart(Driver, Driver.FindElement(".shopping_cart"));

        public BasePage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}