using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Infrastructure
{
    public class HomePage : BasePage
    {
        public IEnumerable<Product> Products => Driver.FindElements("#homefeatured li").Select(element => new Product(Driver, element));
        public TopMenuBlock TopMenuBlock => new TopMenuBlock(Driver, Driver.FindElement(By.CssSelector("#block_top_menu")));

        public HomePage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
