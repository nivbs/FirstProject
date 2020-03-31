using Infrastructure.BaseClasses;
using OpenQA.Selenium;
using Infrastructure.Extensions;

namespace Infrastructure.Common
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
            ParentElement.ClearAndSendKeys(value);
        }

        public string GetText()
            => ParentElement.Text;

        public string GetValue()
            => ParentElement.GetCssValue("value");
    }
}
