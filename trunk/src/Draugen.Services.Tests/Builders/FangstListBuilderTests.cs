using System.Globalization;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders.Queries;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services.Builders
{
    [TestClass]
    public class FangstListBuilderTests
    {
        private string _culture;
        private FangstDto _fangstDto;
        private FangstListBuilder _builder;
        private ServiceHeader _header;
        private PageInfoDto _pageInfo;

        [TestInitialize]
        public void InitializeTest()
        {
            var queryBuilder = new Mock<IQueryBuilder<Fangst>>();
            var fangstRepository = new Mock<IRepository<Fangst>>();
            var fangstAssembler = new Mock<IAssembler<FangstDto, Fangst>>();
            var pageInfoAssembler = new Mock<IAssembler<PageInfoDto, IPageInfo>>();

            var queryObject = new Mock<IQueryManager<Fangst>>();
            var fangst = new Fangst();
            var fangstPage = new Page<Fangst> {fangst};
            _culture = "no";
            _fangstDto = new FangstDto();
            _pageInfo = new PageInfoDto();

            queryBuilder.Setup(q => q.Build()).Returns(queryObject.Object);
            fangstRepository.Setup(r => r.FindAll(queryObject.Object)).Returns(fangstPage);
            fangstAssembler.Setup(a => a.WriteDto(fangst, It.Is<CultureInfo>(c => c.Name == _culture))).Returns(_fangstDto);
            pageInfoAssembler.Setup(p => p.WriteDto(fangstPage, It.Is<CultureInfo>(c => c.Name == _culture))).Returns(_pageInfo);

            _builder = new FangstListBuilder(
                queryBuilder.Object, fangstRepository.Object, fangstAssembler.Object, pageInfoAssembler.Object);

            _header = new ServiceHeader { Culture = _culture };
        }

        [TestMethod]
        public void Build_MustAddFangstDtoPerFangstFromRepository()
        {
            var result = _builder.Build(_header, 1);
            Assert.AreSame(_fangstDto, result[0]);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void Build_MustAddPageInfoFromPageInfoAssembler()
        {
            var result = _builder.Build(_header, 1);
            Assert.AreSame(_pageInfo, result.PageInfo);
        }
    }
}
