using Draugen.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.System.Tests.Data
{
    [TestClass]
    public class DraugenConfigurationTests
    {
        [TestMethod]
        public void BuildSchema_MustCreateContentOfDatabase_WhenDatabaseExists()
        {
            new DraugenConfiguration("Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True").BuildSchema();
        }

        [TestMethod]
        public void GetSessionFactory_MustReturnValidSessionFactory()
        {
            var factory = new DraugenConfiguration("Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True").GetSessionFactory();
            Assert.IsNotNull(factory);
        }
    }
}
