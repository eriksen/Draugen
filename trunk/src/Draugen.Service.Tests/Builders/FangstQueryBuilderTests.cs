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
        public void Ctor_MustInitializeFilter()
        {
            Assert.IsInstanceOfType(_builder.Filter, typeof(ICollection<Filter>));
        }

        [TestMethod]
        public void Build_MustContainDefaultSorts()
        {
            var sort = _builder.Sort;
            var result = _builder.Build();
            Assert.IsTrue(result.Contains(sort));
            Assert.AreEqual("Dato", sort.PropertyName);
            Assert.AreEqual(SortDirection.Descending, sort.Direction);
        }

        [TestMethod]
        public void Build_MustContainDefaultPage()
        {
            var page = _builder.Page;
            var result = _builder.Build();
            Assert.IsTrue(result.Contains(page));
            Assert.AreEqual(1, page.Number);
            Assert.AreEqual(25, page.Size);
        }
    }
}
