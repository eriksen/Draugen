using System.Linq;
using System.Reflection;
using Draugen.Data.QueryObjects;
using Draugen.Services.Dtos.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Services.Builders
{
    [TestClass]
    public class QueryObjectListBuilderTests
    {
        private QueryObjectListBuilder _builder;

        [TestInitialize]
        public void InitializeTest()
        {
            _builder = new QueryObjectListBuilder();
        }

        [TestMethod]
        public void Build_MustIncludeSort()
        {
        }

    }
}
