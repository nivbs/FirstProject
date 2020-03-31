using System.Linq;
using OpenQA.Selenium;
using Infrastructure.Common;
using Infrastructure.BaseClasses;
using Infrastructure.Pages;

namespace Infrastructure.Components
{
    public class TopMenuBlock : ComponentBase
    {
        private Button WomenButton => new Button(Driver, ParentElement.FindElement(By.CssSelector("li:nth-of-type(1) > a")));
        private Button DressesButton => new Button(Driver, ParentElement.FindElement(By.CssSelector("li:nth-of-type(2) > a")));
        private Button TShirtsButton => new Button(Driver, ParentElement.FindElement(By.CssSelector("li:nth-of-type(3) > a")));
        
        public TopMenuBlock(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CatalogPage WomenClick()
            => WomenButton.ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);

        public CatalogPage DressesClick()
            => DressesButton.ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);

        public CatalogPage TShirtsClick()
            => TShirtsButton.ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
    }
}
