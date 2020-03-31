using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Infrastructure
{
    public class FilterRow : ComponentBase
    {
        private IEnumerable<Button> CategoryButtons => ParentElement.FindElements("#ul_layered_category_0 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> SizeButtons => ParentElement.FindElements("#ul_layered_id_attribute_group_1 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> ColorButtons => ParentElement.FindElements("#ul_layered_id_attribute_group_3 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> CompositionButtons => ParentElement.FindElements("#ul_layered_id_feature_5 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> StyleButtons => ParentElement.FindElements("#ul_layered_id_feature_6 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> PropertyButtons => ParentElement.FindElements("#ul_layered_id_feature_7 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> AvailabiltyButtons => ParentElement.FindElements("#ul_layered_quantity_0 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> ManufacturerButtons => ParentElement.FindElements("#ul_layered_manufacturer_0 li label a").Select(element => new Button(Driver, element));
        private IEnumerable<Button> ConditionButtons => ParentElement.FindElements("#ul_layered_condition_0 li label a").Select(element => new Button(Driver, element));


        public FilterRow(IWebDriver driver, IWebElement parentElement)
            : base(driver, parentElement)
        {

        }

        public CatalogPage CategoryClick(string categoryName)
            => CategoryButtons.Where(categoryButton => categoryButton.Text.Contains(categoryName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage SizeClick(string sizeName)
            => SizeButtons.Where(sizeButton => sizeButton.Text.Contains(sizeName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public IEnumerable<string> ColorStyles()
            => ColorButtons.Select(colorButton => colorButton.GetValueByAttribute("style"));
        public CatalogPage FirstColorClick()
            => ColorButtons.First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage ColorClick(string colorName)
                    => ColorButtons.Where(colorButton => colorButton.Text.Contains(colorName)).First()
                        .ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage CompositionClick(string compositionName)
            => CompositionButtons.Where(compositionButton => compositionButton.Text.Contains(compositionName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage StyleClick(string styleName)
            => StyleButtons.Where(styleButton => styleButton.Text.Contains(styleName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage PropertyClick(string propertyName)
            => PropertyButtons.Where(propertyButton => propertyButton.Text.Contains(propertyName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage AvailabiltyClick(string availabiltyName)
            => AvailabiltyButtons.Where(availabiltyButton => availabiltyButton.Text.Contains(availabiltyName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage ManufacturerClick(string manufacturerName)
            => ManufacturerButtons.Where(manufacturerButton => manufacturerButton.Text.Contains(manufacturerName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
        public CatalogPage ConditionClick(string conditionName)
            => ConditionButtons.Where(conditionButton => conditionButton.Text.Contains(conditionName))
                .First().ClickUntilElementExist<CatalogPage>(CssSelectorsInDriver.CatalogPage.First().Value);
    }
}
