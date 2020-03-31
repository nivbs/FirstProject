using FluentAssertions.Primitives;
using Infrastructure.Pages;
using FluentAssertions;
using System.Linq;

namespace Assertions
{
    public class CartPageAssertions : ReferenceTypeAssertions<CartPage, CartPageAssertions>
    {
        public CartPageAssertions(CartPage instance)
        {
            Subject = instance;
        }

        protected override string Identifier => "CartPageAssertions";

        public AndConstraint<CartPage> ProductNotExistInCart(string productName)
        {
            Subject.CartTable.ProductRows
                .Should()
                .NotContain(productRow => productRow.ProductDescription.ProductNameButton.Text == productName,
                "Product Name exist in cart");

            //Execute
            //    .Assertion
            //    .ForCondition(Subject
            //                .CartTable
            //                .ProductRows
            //                .All(productRow =>
            //                    productRow
            //                    .ProductDescription.ProductNameButton
            //                    .Text != productName))
            //    .FailWith("Product Name is exist in cart");

            return new AndConstraint<CartPage>(Subject);
        }

        public AndConstraint<CartPage> QuantityIsEquals(int quantity)
        {
            Subject.CartTable.ProductRows.Count()
                .Should()
                .Be(quantity, $"The Quantity isn't equals to {quantity}");
            //Execute
            //    .Assertion
            //    .ForCondition(Subject
            //                .CartTable
            //                .ProductRows
            //                .Count() == quantity)
            //    .FailWith($"The Quantity isn't equals to {quantity}");

            return new AndConstraint<CartPage>(Subject);
        }
    }
}
