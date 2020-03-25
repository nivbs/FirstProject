using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class Product : ComponentBase
    {
        private Button RemoveButton => new Button(Driver, ParentElement.FindElement(By.CssSelector(".remove_link a")));
        public ProductInfo ProductInfo => new ProductInfo(Driver, ParentElement.FindElement(By.CssSelector(".cart-info")));
        
        public Product(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public BasePage RemoveClick()
            => RemoveButton.Click<BasePage>();
    }
}
