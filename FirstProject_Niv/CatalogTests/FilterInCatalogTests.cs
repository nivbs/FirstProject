using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Pages;
using Infrastructure.Components;
using FluentAssertions;

namespace Tests
{
    [TestClass]
    public class FilterInCatalogTests : BaseCatalogTests
    {
        [TestMethod]
        public void FilterByColorSuccess()
        {
            //string color = WomenCatalogPage.FilterRow.ColorStyles().First();

            //WomenCatalogPage.FilterRow
            //    .ColorClick(color)
            //    .Products
            //    .All(product => product.BottomBlock.ColorsButtons
            //    .Any(colorButton => colorButton.GetColorStyle() == color))
            //    .Should()
            //    .BeTrue();
        }
    }
}
