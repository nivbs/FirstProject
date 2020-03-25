using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Infrastructure
{
    public class Button : ComponentBase
    {
        public Button(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {
            
        }

        public T Click<T>(IWebElement parentElement = null)
             where T:DriverUser
        {
            ParentElement.Click();

            if (parentElement == null)
            {
                return (T)Activator.CreateInstance(typeof(T), Driver);
            }
            else
            {
                return (T)Activator.CreateInstance(typeof(T), Driver, parentElement);
            }
        }

        public string GetText()
            => ParentElement.Text;
    }
}
