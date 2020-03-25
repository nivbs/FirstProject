using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
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
            => WomenButton.Click<CatalogPage>();

        public CatalogPage DressesClick()
            => DressesButton.Click<CatalogPage>();

        public CatalogPage TShirtsClick()
            => TShirtsButton.Click<CatalogPage>();

    }
}
