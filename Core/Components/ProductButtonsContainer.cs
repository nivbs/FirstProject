using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
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
        //=> Utils.FindElement.WaitUntilClickRefreshed<ProductPane>(AddToCartButton, new KeyValuePair<ISearchContext, string>(Driver, "#layer_cart"));
        // => AddToCartButton.Click<ProductPane>(new KeyValuePair<ISearchContext, string>(Driver,"#layer_cart"));
        //{
        //    var productPane = AddToCartButton.Click<ProductPane>(new KeyValuePair<ISearchContext, string>(Driver, "#layer_cart"));
        //    Driver.FindElement("#layer_cart");

        //    return productPane;
        //}
        => AddToCartButton.ClickUntilElementExist<ProductPane>(CssSelectorsInDriver.ProductPane, new KeyValuePair<ISearchContext, string>(Driver, "#layer_cart"));
        
        public ProductPage MoreClick()
            => MoreButton.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);
    }
}
