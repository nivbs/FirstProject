using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using Infrastructure;
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
           Execute
                .Assertion
                .ForCondition(Subject
                            .CartTable
                            .ProductRows
                            .All(productRow =>
                                productRow
                                .ProductDescription.ProductNameButton
                                .GetText() != productName))
                .FailWith("Product Name is exist in cart");

            return new AndConstraint<CartPage>(Subject);
        }

        public AndConstraint<CartPage> QuantityIsEquals(int quantity)
        {
            Execute
                .Assertion
                .ForCondition(Subject
                            .CartTable
                            .ProductRows
                            .Count() == quantity)
                .FailWith($"The Quantity isn't equals to {quantity}");

            return new AndConstraint<CartPage>(Subject);
        }
    }
}
