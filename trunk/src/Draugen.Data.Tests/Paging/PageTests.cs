using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.Paging
{
    [TestClass]
    public class PageTests
    {

        [TestMethod]
        public void TotalPages_MustReturn4_WhenTotalItemsIs10AndSizeIs3()
        {
            var page = new Page<Fangst>() {TotalItems = 10, Size = 3};
            Assert.AreEqual(4, page.TotalPages);
        }

        [TestMethod]
        public void Size_MustDefaultTo1()
        {
            var page = new Page<Fangst>();
            Assert.AreEqual(1, page.Size);
        }
    }
}
