using OpenQA.Selenium;
using System.Linq;

namespace Infrastructure
{
    public class ViewedProductInfo : ComponentBase
    {
        private Button ProductImageButton => new Button(Driver, ParentElement.FindElement(".products-block-image"));
        private Button ProductNameButton => new Button(Driver, ParentElement.FindElement(".product-name"));
        public string Product => ParentElement.FindElement(".product-description").Text;

        public ViewedProductInfo(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public ProductPage ProductImageClick()
            => ProductImageButton.Click<ProductPage>();

        public ProductPage ProductNameClick()
            => ProductNameButton.Click<ProductPage>();

        public string GetProductName()
            => ProductNameButton.GetText();
    }
}