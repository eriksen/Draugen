using Draugen.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.System.Tests.Data
{
    [TestClass]
    public class DraugenConfigurationTests
    {
        [TestMethod, Ignore]
        public void BuildSchema_MustCreateContentOfDatabase_WhenDatabaseExists()
        {
            new DraugenConfiguration().BuildSchema("Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True");
        }

        [TestMethod]
        public void GetSessionFactory_MustReturnValidSessionFactory()
        {
            var factory = new DraugenConfiguration().GetSessionFactory();
            Assert.IsNotNull(factory);
        }
    }
}
