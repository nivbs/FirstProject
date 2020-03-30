using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class ProductInCart : ComponentBase
    {
        private Button RemoveButton => new Button(Driver, ParentElement.FindElement(".remove_link a"));
        public ProductInfoInCart ProductInfo => new ProductInfoInCart(Driver, ParentElement.FindElement(".cart-info"));
        
        public ProductInCart(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CartPage RemoveClick()
            => RemoveButton.ClickUntilElementExist<CartPage>(CssSelectorsInDriver.CartPage.First().Value);
    }
}
