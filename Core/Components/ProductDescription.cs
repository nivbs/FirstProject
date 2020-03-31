using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Infrastructure.Common;
using Infrastructure.BaseClasses;
using Infrastructure.Extensions;

namespace Infrastructure.Components
{
    public class ProductDescription : ComponentBase
    {
        public Button ProductNameButton => new Button(Driver, ParentElement.FindElement(".product-name"));
        //there are more properties but its not importent for now

        public ProductDescription(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {
        }
    }
}
