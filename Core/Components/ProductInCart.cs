using System.Linq;
using OpenQA.Selenium;
using Infrastructure.Pages;
using Infrastructure.Common;
using Infrastructure.BaseClasses;
using Infrastructure.Extensions;

namespace Infrastructure.Components
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
