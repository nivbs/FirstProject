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

        public string GetXPath(IWebElement element, string currentXPath)
        {
            string childTag = element.TagName;
            if(childTag.Equals("html"))
            {
                return $"/html[1]{currentXPath}";
            }
            IWebElement parentElement = element.FindElement(By.XPath(childTag));
            List<IWebElement> childrenElement = parentElement.FindElements(By.XPath("*")).ToList();
            int count = 0;
            foreach(IWebElement childElement in childrenElement)
            {
                if(childTag.Equals(childElement.TagName))
                {
                    count++;
                }
                if (childrenElement.Count == 1)
                    return GetXPath(parentElement, $"/{childTag}[{count}]{currentXPath}");
            }

            return null;
        }

        public Point GetLocation()
            => ParentElement.Location;
    }
}