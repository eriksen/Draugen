using System.Collections.Generic;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Services.Builders.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Services.Builders
{
    [TestClass]
    public class FangstQueryBuilderTests
    {
        private FangstQueryBuilder _builder;

        [TestInitialize]
        public void InitializeTest()
        {
            _builder = new FangstQueryBuilder();
        }

        [TestMethod]
        public void Build_MustContainDefaultSorts()
        {
        }

        [TestMethod]
        public void Build_MustContainDefaultPage()
        {
        }
    }
}
