using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data
{
    [TestClass]
    public class DraugenConfigurationTests
    {
        [TestMethod]
        public void Dispose_CanExecute()
        {
            var configuration = new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True");
            configuration.Dispose();
        }
    }
}
