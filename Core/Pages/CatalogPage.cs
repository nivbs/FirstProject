using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class CatalogPage : BasePage
    {
        public IEnumerable<Product> Products => Driver.FindElements(".product_list .ajax_block_product").Select(element => new Product(Driver, element));
        public FilterRow FilterRow => new FilterRow(Driver, Driver.FindElement(By.CssSelector("#left_column")));

        public CatalogPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
