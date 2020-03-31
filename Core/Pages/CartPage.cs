using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Components;
using Infrastructure.Extensions;

namespace Infrastructure.Pages
{
    public class CartPage : BasePage
    {
        public CartTable CartTable => new CartTable(Driver, Driver.FindElement(".row #center_column"));

        public CartPage(IWebDriver driver)
            : base(driver)
        {

        }
    }
}
