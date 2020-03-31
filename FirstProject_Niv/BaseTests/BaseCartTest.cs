using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Pages;
using Infrastructure.Components;

namespace Tests
{
    [TestClass]
    public abstract class BaseCartTest : BaseUnitTest
    {
        protected CartPage CartPage { get; set; }
        protected ProductPane ProductPane { get; set; }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            ProductPane = HomePage.AddToCartProductByIndex(0);
        }
    }
}
