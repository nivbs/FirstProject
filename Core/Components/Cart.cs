using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Cart : ComponentBase
    {
        private Button MyShippingButton => new Button(Driver, ParentElement.FindElement(By.CssSelector("a")));
        public IEnumerable<Product> Products => ParentElement.FindElements(By.CssSelector(".products dt")).Select(element => new Product(Driver, element));
        public double ShippingPrice => double.Parse(ParentElement.FindElement(By.CssSelector(".cart_block_shipping_cost")).Text.Replace("$", string.Empty));
        public double TotalPrice => double.Parse(ParentElement.FindElement(By.CssSelector(".cart_block_total")).Text.Replace("$", string.Empty));
        private Button CheckOutButton => new Button(Driver, ParentElement.FindElement(By.CssSelector("#button_order_cart")));

        public Cart(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public BasePage CheckOutClick()
            => CheckOutButton.Click<BasePage>();

        public CartPage MyShippingClick()
            => MyShippingButton.Click<CartPage>();
    }
}