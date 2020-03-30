using System;
using System.Collections.Generic;
using System.Linq;
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
        => ContinueShoppingButton.ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        

        public HomePage ContinueShoppingClickInHome()
            => ContinueShoppingButton.ClickUntilElementExist<HomePage>(CssSelectorsInDriver.HomePage.First().Value);

        public CartPage ProceedToCheckoutClick()
        // => (CartPage)Utils.FindElement.WaitUntilNotExist(ParentElement, ProceedToCheckoutButton.Click<CartPage>());
        => ProceedToCheckoutButton.ClickUntilElementExist<CartPage>(CssSelectorsInDriver.CartPage.First().Value);

        public CatalogPage ExitClickInCatalog()
            => ExitButton.ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);

        public HomePage ExitClickInHome()
            => ExitButton.ClickUntilElementExist<HomePage>(CssSelectorsInDriver.HomePage.First().Value);
    }
}
