using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Item : ComponentBase
    {
        public TopBlock TopBlock => new TopBlock(Driver, ParentElement.FindElement(By.CssSelector(".left-block")));
        public BottomBlock BottomBlock => new BottomBlock(Driver, ParentElement.FindElement(By.CssSelector(".right-block")));

        public Item(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
