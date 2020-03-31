using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infrastructure.Pages;

namespace Tests
{
    [TestClass]
    public abstract class BaseCatalogTests : BaseUnitTest
    {
        protected CatalogPage WomenCatalogPage { get; set; }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            WomenCatalogPage = HomePage.TopMenuBlock.WomenClick();
        }
    }
}
