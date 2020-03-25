using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Core
{
    public class TextBox : ComponentBase
    {
        public TextBox(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public void Fill(string value)
        {
            ParentElement.SendKeys(value);
        }

        public void Clear()
        {
            ParentElement.Clear();
        }

        public void FillNewValue(string value)
        {
            Clear();
            Fill(value);
        }
    }
}
