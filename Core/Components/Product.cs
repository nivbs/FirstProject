using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Product : ComponentBase
    {
        public TopProductBlock TopBlock => new TopProductBlock(Driver, ParentElement.FindElement(".left-block"));
        public BottomProductBlock BottomBlock => new BottomProductBlock(Driver, ParentElement.FindElement(".right-block"));

        public Product(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
