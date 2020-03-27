using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;

namespace Assertions
{
    public static class AssertionsExtensions
    {
        public static ProductRowAssertions Should(this ProductRow productRow)
            => new ProductRowAssertions(productRow);

        public static CartPageAssertions Should(this CartPage cartPage)
            => new CartPageAssertions(cartPage);
    }
}