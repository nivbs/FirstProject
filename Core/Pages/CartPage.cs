using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class CartPage : BasePage
    {
        public CartTable CartTable => new CartTable(Driver, Driver.FindElement(By.CssSelector("#cart_summary")));

        public CartPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
