using System.Web.Mvc;
using System.Web.Routing;
using Draugen.Services.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Helpers
{
    [TestClass]
    public class PageHelpersTests
    {
        private HtmlHelper _helper;

        [TestInitialize]
        public void InitializeTest()
        {
            var viewContext = new ViewContext {RouteData = new RouteData()};
            _helper = new HtmlHelper(viewContext, new Mock<IViewDataContainer>().Object);
        }


        [TestMethod]
        public void PageFirstLink_MustReturnLinkToFirstPage_WhenCurrentPageIsGt6()
        {
            var result = _helper.PageFirstLink(new PageInfoDto {Index = 7});
            Verify(result, "1", "1", "");
        }


        [TestMethod]
        public void PageFirstLink_MustReturnEmpty_WhenCurrentPageIsLt7()
        {
            var result = _helper.PageFirstLink(new PageInfoDto { Index = 6 });
            Assert.AreEqual(MvcHtmlString.Empty, result);
        }

        [TestMethod]
        public void PageLastLink_MustReturnLinkToLastPage_WhenCurrentPageIsLtTotalMinus6()
        {
            var result = _helper.PageLastLink(new PageInfoDto {Index = 3, TotalPages = 10});
            Verify(result, "10", "10", "");
        }

        [TestMethod]
        public void PageLastLink_MustReturnEmpty_WhenCurrentPageIsgtTotalPagesMinus7()
        {
            var result = _helper.PageLastLink(new PageInfoDto { Index = 4, TotalPages = 10 }); 
            Assert.AreEqual(MvcHtmlString.Empty, result);
        }

        [TestMethod]
        public void PageNextLink_MustReturnEmpty_WhenCurrentPageIsLastPage()
        {
            var result = _helper.PageNextLink(new PageInfoDto { Index = 10, TotalPages = 10 }); 
            Assert.AreEqual(MvcHtmlString.Empty, result);
        }

        [TestMethod]
        public void PageNextLink_MustReturnLinkToCurrenPlus1_WhenCurrentPageIsNotLastPage()
        {
            var result = _helper.PageNextLink(new PageInfoDto { Index = 5, TotalPages = 10 }); 
            Verify(result, "6", "Next", "");
        }

        [TestMethod]
        public void PageIndexLink_MustReturnEmpty_WhenCurrIndexIsLtIndexMinus5()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 9, TotalPages = 10 }, 3);
            Assert.AreEqual(MvcHtmlString.Empty, result);
        }

        [TestMethod]
        public void PageIndexLink_MustReturnEmpty_WhenCurrIndexIsGtIndexPlus5()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 3, TotalPages = 10 }, 9);
            Assert.AreEqual(MvcHtmlString.Empty, result);
        }

        [TestMethod]
        public void PageIndexLink_MustReturnDotText_WhenIndexIsCurrIndexMinus5AndIndexIsGt2()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 3, TotalPages = 10 }, 8);
            Verify(result, "8", "...", "");
        }

        [TestMethod]
        public void PageIndexLink_MustNotReturnDotText_WhenIndexIsCurrIndexMinus5AndIndexIsLt2()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 7, TotalPages = 10 }, 2);
            Verify(result, "2", "2", "");
        }

        [TestMethod]
        public void PageIndexLink_MustReturnDotText_WhenIndexIsCurrIndexPlus5AndIndexIsLtTotalPagesMinus1()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 8, TotalPages = 10 }, 3);
            Verify(result, "3", "...", "");
        }

        [TestMethod]
        public void PageIndexLink_MustNotReturnDotText_WhenIndexIsCurrIndexMinus5AndIndexIsGtTotalPagesMinus1()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 4, TotalPages = 10 }, 9);
            Verify(result, "9", "9", "");
        }

        [TestMethod]
        public void PageIndexLink_MustReturnOrdinaryLink_WhenAllIsOrdinary()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 11, TotalPages = 20 }, 10);
            Verify(result, "10", "10", "");
            Assert.IsFalse(result.ToString().StartsWith("<strong>"));
            Assert.IsFalse(result.ToString().EndsWith("</strong>"));
        }

        [TestMethod]
        public void PageIndexLink_MustReturnStrongLink_WhenIndexIsCurrIndex()
        {
            var result = _helper.PageIndexLink(new PageInfoDto { Index = 4, TotalPages = 10 }, 4);
            Verify(result, "4", "4", "");
            Assert.IsTrue(result.ToString().StartsWith("<strong>"));
            Assert.IsTrue(result.ToString().EndsWith("</strong>"));
        }

        private void Verify(MvcHtmlString result, string page, string text, string title)
        {
            Assert.AreEqual(page, _helper.ViewContext.RouteData.Values["page"]);
            Assert.IsTrue(result.ToString().Contains(">" + text + "<"), "text: " + text);
            Assert.IsTrue(result.ToString().Contains(" title=\"" + title + "\""), "title: " + title);
            Assert.IsTrue(result.ToString().Contains(" class=\"pagelink\""));
        }

    }
}
