﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class BottomBlock : ComponentBase
    {
        public string ProductName => ParentElement.FindElement(By.CssSelector(".product-name")).Text;
        public ProductButtonsContainer ItemButtonsContainer => new ProductButtonsContainer(Driver, ParentElement.FindElement(".button-container"));
        public IEnumerable<Button> ColorsButtons => ParentElement.FindElements(By.CssSelector(".color_pick")).Select(element => new Button(Driver, element));

        public BottomBlock(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}
