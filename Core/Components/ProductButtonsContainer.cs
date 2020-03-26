using System;
using System.Collections.Generic;
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
            => AddToCartButton.Click<ProductPane>(Driver.FindElement(By.CssSelector("#layer_cart")));

        //Change to ItemPage
        public BasePage MoreClick()
            => MoreButton.Click<BasePage>();
    }
}
