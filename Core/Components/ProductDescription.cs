using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class ProductDescription : ComponentBase
    {
        public Button ProductNameButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".product-name")));
        //there is more properties but its not importent

        public ProductDescription(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {
        }
    }
}
