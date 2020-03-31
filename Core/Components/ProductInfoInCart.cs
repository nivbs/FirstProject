using System.Linq;
using OpenQA.Selenium;
using Infrastructure.Common;
using Infrastructure.BaseClasses;
using Infrastructure.Pages;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class ProductInfoInCart : ComponentBase
    {
        public int Quantity => int.Parse(ParentElement.FindElement(".quantity").Text);
        private Button ProductNameButton => new Button(Driver, ParentElement.FindElement(".cart_block_product_name"));
        public double Price => double.Parse(ParentElement.FindElement(".price").Text.Replace("$", string.Empty));
        
        public ProductInfoInCart(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public string GetProductName()
            => ProductNameButton.GetValueByAttribute("title");

        public ProductPage ProductNameClick()
            => ProductNameButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);
    }
}
