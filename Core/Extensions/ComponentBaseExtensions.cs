using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public static class ComponentBaseExtensions
    {
        public static T WaitUntilAttributeEquals<T>(this T componentBase, string attribute
            , string expectedValue, int seconds = 20)
             where T : ComponentBase
        {
            DefaultWait<T> defaultWait = new DefaultWait<T>(componentBase);
            defaultWait.Timeout = TimeSpan.FromSeconds(seconds);
            defaultWait.IgnoreExceptionTypes(typeof(ElementNotInteractableException),
                typeof(StaleElementReferenceException), typeof(NoSuchElementException));

            return defaultWait.Until(component =>
            {
                if (component.GetValueByAttribute(attribute) == expectedValue)
                {
                    return component;
                }

                return null;
            });
        }
    }
}
