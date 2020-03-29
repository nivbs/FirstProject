using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Infrastructure
{
    public class ProductPage : BasePage
    {
        public ProductInfoInProductPage ProductInfo => new ProductInfoInProductPage(Driver, Driver.FindElement("#center_column .primary_block"));

        public ProductPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
