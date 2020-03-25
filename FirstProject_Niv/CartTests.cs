using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using FluentAssertions;
using System.Linq;

namespace FirstProject_Niv
{
    [TestClass]
    public class CartTests : BaseUnitTest
    {
        protected CartPage CartPage { get; set; }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            CartPage = HomePage.Items.First()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ContinueShoppingClickInHome()
                .Items.Last()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ContinueShoppingClickInHome()
                .Cart
                .MyShippingClick();
        }

        [TestMethod]
        public void RemoveProductSuccess()
        {
            string itemName = CartPage.CartTable.ProductRows.First().ProductDescription.ProductNameButton.GetText();

            CartPage
                .CartTable.ProductRows.First()
                .DeleteClick()
                .CartTable.ProductRows
                .ToList()
                .ForEach(productRow => 
                            productRow
                            .ProductDescription.ProductNameButton
                            .GetText()
                            .Should()
                            .NotBe(itemName));
        }

        [TestMethod]
        public void AddQuanintyOfProductSuccess()
        {

        }
    }
}
