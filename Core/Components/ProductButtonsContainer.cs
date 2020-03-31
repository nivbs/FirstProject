using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Infrastructure.Pages;
using Infrastructure.BaseClasses;
using Infrastructure.Common;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class ProductButtonsContainer : ComponentBase
    {
        private Button AddToCartButton => new Button(Driver, ParentElement.FindElement(".ajax_add_to_cart_button"));
        private Button MoreButton => new Button(Driver, ParentElement.FindElement(".lnk_view"));

        public ProductButtonsContainer(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public ProductPane AddToCartClick()
            => AddToCartButton.ClickUntilElementExist<ProductPane>(CssSelectorsInDriver.ProductPane, new KeyValuePair<ISearchContext, string>(Driver, "#layer_cart"));
        
        public ProductPage MoreClick()
            => MoreButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);
    }
}
