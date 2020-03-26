using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using FluentAssertions;
using Extensions;


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

            CartPage = HomePage.Products.First()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ContinueShoppingClickInHome()
                .Products.Last()
                .BottomBlock.ItemButtonsContainer
                .AddToCartClick()
                .ProceedToCheckoutClick();
        }

        [TestMethod]
        public void RemoveProductSuccess()
        {
            string itemName = CartPage.GetFirstProductRow().ProductDescription.ProductNameButton.GetText();

            CartPage
                .GetFirstProductRow()
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
            double totalPrice = CartPage
                .GetFirstProductRow().Quantity
                .PlusClick()
                .GetFirstProductRow()
                .TotalPrice;

            totalPrice
                .Should()
                .Be((double.Parse(CartPage.GetFirstProductRow()
                .Quantity.QuantityTextBox.GetValue())
                * CartPage.GetFirstProductRow().UnitPrice));
        }
    }
}
