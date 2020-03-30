using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class ProductPane : ComponentBase
    {
        private Button ContinueShoppingButton => new Button(Driver, ParentElement.FindElement(".continue"));
        private Button ProceedToCheckoutButton => new Button(Driver, ParentElement.FindElement("[title='Proceed to checkout']"));
        private Button ExitButton => new Button(Driver, ParentElement.FindElement(By.CssSelector("div.layer_cart_product.col-xs-12.col-md-6 > span")));
        
        public ProductPane(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CatalogPage ContinueShoppingClickInCatalog()
        //=> Utils.FindElement.WaitUntilClickRefreshed<CatalogPage>(ContinueShoppingButton);
        //=> ContinueShoppingButton.Click<CatalogPage>();
        {
            var  ContinueShoppingButton.Click<CatalogPage>();
        }

        public HomePage ContinueShoppingClickInHome()
            => ContinueShoppingButton.Click<HomePage>();

        public CartPage ProceedToCheckoutClick()
        // => (CartPage)Utils.FindElement.WaitUntilNotExist(ParentElement, ProceedToCheckoutButton.Click<CartPage>());
        {
            var cartPage = ProceedToCheckoutButton.Click<CartPage>();
            var cartTable = cartPage.CartTable;

            return cartPage;
        }

        public CatalogPage ExitClickInCatalog()
            => ExitButton.Click<CatalogPage>();

        public HomePage ExitClickInHome()
            => ExitButton.Click<HomePage>();
    }
}
