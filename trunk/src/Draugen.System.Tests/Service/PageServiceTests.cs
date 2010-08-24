using Draugen.Initialize;
using Draugen.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;

namespace Draugen.Service
{
    [TestClass]
    public class PageServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var container = UnityContainerFactory.Create();
            var service = container.Resolve<IViewDataService>();
            var page = service.GetHomePageData();
        }
    }
}
