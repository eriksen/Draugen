using Draugen.Services;
using Draugen.Setup;
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
            var service = container.Resolve<IPageService>();
            var page = service.GetHomePageData();
        }
    }
}
