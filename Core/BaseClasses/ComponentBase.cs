using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public abstract class ComponentBase : DriverUser
    {
        protected IWebElement ParentElement { get; private set; }

        public ComponentBase(IWebDriver driver, IWebElement parentElement)
            : base(driver)
        {
            ParentElement = parentElement;
        }

        public string GetValueByAttribute(string property)
            => ParentElement.GetAttribute(property);

        public override string ToString()
        {
            return ParentElement.ToString();
        }

        public bool IsEnabled()
            => ParentElement.Enabled;

        public bool IsDisplayed()
            => ParentElement.Displayed;

        public Point GetLocation()
            => ParentElement.Location;
    }
}