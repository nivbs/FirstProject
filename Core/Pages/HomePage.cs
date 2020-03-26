using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Infrastructure
{
    public class HomePage : BasePage
    {
        public Cart Cart => new Cart(Driver, Driver.FindElement(By.CssSelector(".shopping_cart")));
        public IEnumerable<Product> Products => Driver.FindElements("#homefeatured").Select(element => new Product(Driver, element));
        public TopMenuBlock TopMenuBlock => new TopMenuBlock(Driver, Driver.FindElement(By.CssSelector("#block_top_menu")));

        public HomePage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
