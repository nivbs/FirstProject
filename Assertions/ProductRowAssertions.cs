using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using Infrastructure;
using FluentAssertions;

namespace Assertions
{
    public class ProductRowAssertions : ReferenceTypeAssertions<ProductRow, ProductRowAssertions>
    {
        public ProductRowAssertions(ProductRow instance)
        {
            Subject = instance;
        }

        protected override string Identifier => "CartPageAssertions";

        public AndConstraint<ProductRow> TotalPriceIsTrue()
        {
            Execute
                .Assertion
                .ForCondition(Subject.TotalPrice == (2.0 * Subject.UnitPrice))
                .FailWith("Total Price is not equal to the quantity multiple unit price");

            return new AndConstraint<ProductRow>(Subject);
        }
    }
}
