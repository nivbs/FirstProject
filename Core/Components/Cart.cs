using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Cart : ComponentBase
    {
        private Button MyShippingButton => new Button(Driver, ParentElement.FindElement("a"));
        public IEnumerable<ProductInCart> Products => ParentElement.FindElements(".products dt").Select(element => new ProductInCart(Driver, element));
        public double ShippingPrice => double.Parse(ParentElement.FindElement(".cart_block_shipping_cost").Text.Replace("$", string.Empty));
        public double TotalPrice => double.Parse(ParentElement.FindElement(".cart_block_total").Text.Replace("$", string.Empty));
        private Button CheckOutButton => new Button(Driver, ParentElement.FindElement("#button_order_cart"));

        public Cart(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CartPage CheckOutClick()
            => CheckOutButton.ClickUntilElementExist<CartPage>("");

        public CartPage MyShippingClick()
            => MyShippingButton.ClickUntilElementExist<CartPage>("");
    }
}