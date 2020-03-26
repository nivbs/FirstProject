using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Infrastructure
{
    public static class ISearchContextExtensions
    {
        public static IWebElement FindElement(this ISearchContext searchContext, string cssSelector, int seconds = 5)
        {
            DefaultWait<ISearchContext> defaultWait = new DefaultWait<ISearchContext>(searchContext);
            defaultWait.IgnoreExceptionTypes(typeof(ElementNotInteractableException), typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            return defaultWait.Until<IWebElement>(sc => sc.FindElement(By.CssSelector(cssSelector)));
        }

        public static IEnumerable<IWebElement> FindElements(this ISearchContext searchContext, string cssSelector, int seconds = 5)
        {
            DefaultWait<ISearchContext> defaultWait = new DefaultWait<ISearchContext>(searchContext);
            defaultWait.IgnoreExceptionTypes(typeof(ElementNotInteractableException), typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            return defaultWait.Until<IEnumerable<IWebElement>>(sc => sc.FindElements(By.CssSelector(cssSelector)));
        }
    }
}
