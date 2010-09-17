using System.Reflection;
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
        public void Build_MustReturnQueryBuilderThatDefaultSortsOnDateDescending()
        {
            var query = _builder.Build();
            var sort = GetFieldValue<SortQuery<Fangst>, Fangst>(query, "_sortQueryQuery");
            Assert.AreEqual(SortDirection.Descending, sort.Direction);
            Assert.AreEqual("Dato", sort.PropertyName);
        }

        [TestMethod]
        public void Build_MustReturnQueryBuilderThatDefaultPageIndexIsOneWithSize25()
        {
            var query = _builder.Build();
            var page = GetFieldValue<PageQuery<Fangst>, Fangst>(query, "_pageQueryQuery");
            Assert.AreEqual(1, page.Index);
            Assert.AreEqual(25, page.Size);
        }

        protected static TField GetFieldValue<TField, TDomain>(IQueryManager<TDomain> query, string fieldName) where TDomain : DomainObject
        {
            return (TField)query.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(query);
        }

    }
}
