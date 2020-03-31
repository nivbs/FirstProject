using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions;
using FluentAssertions;
using Assertions;
using Infrastructure.Components;
using Infrastructure.Pages;

namespace Tests
{
    [TestClass]
    public class CartWithTwoProductsTests : BaseCartTest
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            HomePage = ProductPane.ContinueShoppingClickInHome();
            CartPage = HomePage.AddToCartProductByIndex(HomePage.Products.Count()-1)
                        .ProceedToCheckoutClick();
        }

        [TestMethod]
        public void RemoveProductWhileTwoProductsInCartSuccess()
        {
            string productName = CartPage.GetFirstProductRow().ProductDescription.ProductNameButton.Text;
            int countOfProducts = CartPage.CartTable.ProductRows.Count();
            
            CartPage
                .GetFirstProductRow()
                .DeleteClick()
                .Should()
                .ProductNotExistInCart(productName)
                .And
                .Should()
                .QuantityIsEquals(countOfProducts - 1);
        }
    }
}
