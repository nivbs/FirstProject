﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Product : ComponentBase
    {
        public TopBlock TopBlock => new TopBlock(Driver, ParentElement.FindElement(".left-block"));
        public BottomBlock BottomBlock => new BottomBlock(Driver, ParentElement.FindElement(".right-block"));

        public Product(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }
    }
}