using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Components;
using Infrastructure.Extensions;

namespace Infrastructure.Pages
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
