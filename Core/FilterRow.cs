using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Core
{
    public class FilterRow : ComponentBase
    {
        private IEnumerable<Button> CategoryButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_category_0 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> SizeButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_id_attribute_group_1 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> ColorButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_id_attribute_group_3 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> CompositionButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_id_feature_5 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> StyleButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_id_feature_6 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> PropertyButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_id_feature_7 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> AvailabiltyButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_quantity_0 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> ManufacturerButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_manufacturer_0 li label a")).Select(element => new Button(Driver, element));
        private IEnumerable<Button> ConditionButtons => ParentElement.FindElements(By.CssSelector("#ul_layered_condition_0 li label a")).Select(element => new Button(Driver, element));


        public FilterRow(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CatalogPage CategoryClick(string categoryName)
            => CategoryButtons.Where(categoryButton => categoryButton.GetText().Contains(categoryName))
                .First().Click<CatalogPage>();
        public CatalogPage SizeClick(string sizeName)
            => SizeButtons.Where(sizeButton => sizeButton.GetText().Contains(sizeName))
                .First().Click<CatalogPage>();
        public CatalogPage ColorClick(string colorName)
                    => ColorButtons.Where(colorButton => colorButton.GetText().Contains(colorName))
                        .First().Click<CatalogPage>();
        public CatalogPage CompositionClick(string compositionName)
            => CompositionButtons.Where(compositionButton => compositionButton.GetText().Contains(compositionName))
                .First().Click<CatalogPage>();
        public CatalogPage StyleClick(string styleName)
            => StyleButtons.Where(styleButton => styleButton.GetText().Contains(styleName))
                .First().Click<CatalogPage>();
        public CatalogPage PropertyClick(string propertyName)
            => PropertyButtons.Where(propertyButton => propertyButton.GetText().Contains(propertyName))
                .First().Click<CatalogPage>();
        public CatalogPage AvailabiltyClick(string availabiltyName)
            => AvailabiltyButtons.Where(availabiltyButton => availabiltyButton.GetText().Contains(availabiltyName))
                .First().Click<CatalogPage>();
        public CatalogPage ManufacturerClick(string manufacturerName)
            => ManufacturerButtons.Where(manufacturerButton => manufacturerButton.GetText().Contains(manufacturerName))
                .First().Click<CatalogPage>();
        public CatalogPage ConditionClick(string conditionName)
            => ConditionButtons.Where(conditionButton => conditionButton.GetText().Contains(conditionName))
                .First().Click<CatalogPage>();
    }
}
