using System.Linq;
using OpenQA.Selenium;
using Infrastructure.BaseClasses;
using Infrastructure.Common;
using Infrastructure.Pages;

namespace Infrastructure.Components
{
    public class ColorButton : ComponentBase
    {
        public Button Button => new Button(Driver, ParentElement);

        public ColorButton(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public ProductPage ColorClick()
            => Button.ClickUntilElementExist<ProductPage>(CssSelectorsInDriver.ProductPage.First().Value);

        public string GetColorStyle()
            => Button.GetValueByAttribute("style");
    }

}
