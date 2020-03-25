using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class CatalogPage : BasePage
    {
        public IEnumerable<Item> Items => Driver.FindElements(By.CssSelector(".product-container")).Select(element => new Item(Driver, element));
        public FilterRow FilterRow => new FilterRow(Driver, Driver.FindElement(By.CssSelector("#left_column")));

        public CatalogPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
