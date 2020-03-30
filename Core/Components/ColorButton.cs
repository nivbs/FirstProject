using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;

namespace Infrastructure
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
