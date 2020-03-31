using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Utils;
using Extensions;
using FluentAssertions;
using System.Threading;
using Assertions;

namespace FirstProject_Niv
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
