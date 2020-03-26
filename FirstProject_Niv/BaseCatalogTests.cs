using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace FirstProject_Niv
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
