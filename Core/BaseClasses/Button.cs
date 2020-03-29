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

        public T Click<T>(KeyValuePair<ISearchContext, string> keyValuePair = new KeyValuePair<ISearchContext, string>())
             where T:DriverUser
        {
            ParentElement.Click();

            if (keyValuePair.Value == null && keyValuePair.Key == null)
            {
                return (T)Activator.CreateInstance(typeof(T), Driver);
            }
            else
            {
                return (T)Activator.CreateInstance(typeof(T), Driver, keyValuePair.Key.FindElement(keyValuePair.Value));
            }
        }

        public string GetText()
            => ParentElement.Text;

        public string GetLink()
            => GetValueByAttribute("href");
    }
}
