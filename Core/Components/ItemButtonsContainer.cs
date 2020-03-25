using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class ItemButtonsContainer : ComponentBase
    {
        private Button AddToCartButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".ajax_add_to_cart_button")));
        private Button MoreButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".lnk_view")));

        public ItemButtonsContainer(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CatalogPage AddToCartClick()
            => AddToCartButton.Click<CatalogPage>();

        //Change to ItemPage
        public BasePage MoreClick()
            => MoreButton.Click<BasePage>();
    }
}
