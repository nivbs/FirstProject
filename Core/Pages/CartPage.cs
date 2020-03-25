using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class CartPage : BasePage
    {
        public CartTable CartTable => new CartTable(Driver, Driver.FindElement(By.CssSelector(".row #center_column")));

        public CartPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
