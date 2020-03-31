using Infrastructure.Components;
using Infrastructure.Pages;

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