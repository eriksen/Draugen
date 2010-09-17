using System;
using System.Globalization;
using Draugen.Data.Paging;
using Draugen.Services.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Services.Assemblers
{
    [TestClass]
    public class PageInfoAssemblerTest
    {
        private PageInfoAssembler _assembler;

        [TestInitialize]
        public void InitializeTest()
        {
            _assembler = new PageInfoAssembler();
        }

        [TestMethod]
        public void WriteDto_MustSetInfoFromDomainObject()
        {
            var domain = new Page<Art> {Index = 1, Size = 25, TotalItems = 100};
            var pageInfo = _assembler.WriteDto(domain, new CultureInfo("no"));
            
            Assert.AreEqual(1, pageInfo.Index);
            Assert.AreEqual(25, pageInfo.Size);
            Assert.AreEqual(100, pageInfo.TotalItems);
            Assert.AreEqual(4, pageInfo.TotalPages);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void Create_MustThrowNotImplementedException()
        {
            _assembler.Create(new PageInfoDto());
        }
    }
}
