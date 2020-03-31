using OpenQA.Selenium;
using System.Linq;
using Infrastructure.BaseClasses;
using Infrastructure.Common;
using Infrastructure.Pages;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class ViewedProductInfo : ComponentBase
    {
        private Button ProductImageButton => new Button(Driver, ParentElement.FindElement(".products-block-image"));
        private Button ProductNameButton => new Button(Driver, ParentElement.FindElement(".product-name"));
        public string Product => ParentElement.FindElement(".product-description").Text;

        public ViewedProductInfo(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public ProductPage ProductImageClick()
            => ProductImageButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);

        public ProductPage ProductNameClick()
            => ProductNameButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);

        public string GetProductName()
            => ProductNameButton.Text;
    }
}