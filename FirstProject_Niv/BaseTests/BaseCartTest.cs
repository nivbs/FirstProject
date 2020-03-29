using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.Utils;

namespace FirstProject_Niv
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

            ProductPane = AddToCartFromHome.FirstProduct(HomePage);
        }
    }
}
