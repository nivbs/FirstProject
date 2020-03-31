using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Components;
using Infrastructure.Extensions;

namespace Infrastructure.Pages
{
    public class CatalogPage : BasePage
    {
        public IEnumerable<Product> Products => Driver.FindElements(".product_list .ajax_block_product").Select(element => new Product(Driver, element));
        public FilterRow FilterRow => new FilterRow(Driver, Driver.FindElement("#left_column"));

        public CatalogPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
