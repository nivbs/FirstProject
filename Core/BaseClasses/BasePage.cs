using OpenQA.Selenium;
using Infrastructure.Common;
using Infrastructure.Components;
using Infrastructure.Extensions;

namespace Infrastructure.BaseClasses
{
    public abstract class BasePage : DriverUser
    {
        public Cart Cart => new Cart(Driver, Driver.FindElement(CssSelectorsInDriver.Cart));

        public BasePage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}