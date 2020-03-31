using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using FluentAssertions;
using Infrastructure.Components;

namespace Tests
{
    [TestClass]
    public class ClickingInCatalogTests : BaseCatalogTests
    {
        [TestMethod]
        public void AddToCartSuccess()
        {
            string firstProductName = WomenCatalogPage.Products.First().BottomBlock.ProductName;

            WomenCatalogPage.Products.First()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ContinueShoppingClickInCatalog()
                .Cart.Products
                .Any(product => product.ProductInfo.GetProductName() == firstProductName)
                .Should()
                .BeTrue();
        }

        [TestMethod]
        public void ClickOnColorOfProductSuccess()
        {
            ColorButton firstColorButton = WomenCatalogPage.Products.First()
                                            .BottomBlock
                                            .ColorsButtons.ToList()[0];

            firstColorButton
                .GetColorStyle()
                .Should()
                .Be(firstColorButton
                .ColorClick()
                .ProductInfo
                .GetSelectedColorStyle());
        }
    }
}
