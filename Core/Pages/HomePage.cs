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
        public TopMenuBlock TopMenuBlock => new TopMenuBlock(Driver, Driver.FindElement("#block_top_menu"));

        public HomePage(IWebDriver driver)
            : base(driver)
        {

        }

        public ProductPane AddToCartProductByIndex(int index)
        {
            if (index >= 0 && index < Products.Count())
            {
                return Products.ToList()[index]
                      .BottomBlock.ItemButtonsContainer
                      .AddToCartClick();
            }

            return AddToCartProductByIndex(0);
        }
    }
}
