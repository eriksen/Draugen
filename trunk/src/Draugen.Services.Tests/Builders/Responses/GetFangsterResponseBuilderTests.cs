using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services.Builders.Responses
{
    [TestClass]
    public class GetFangsterResponseBuilderTests
    {
        private Mock<IListBuilder<FangstListDto>> _fangstListBuilder;
        private GetFangsterResponseBuilder _builder;
        private FangstListDto _fangstList;
        private GetFangsterRequest _request;

        [TestInitialize]
        public void InitializeTest()
        {
            var header = new ServiceHeader();
            _fangstList = new FangstListDto(new FangstDto[]{});

            _fangstListBuilder = new Mock<IListBuilder<FangstListDto>>();
            _fangstListBuilder.Setup(f => f.Build(header, 1)).Returns(_fangstList);
            
            _builder = new GetFangsterResponseBuilder(_fangstListBuilder.Object);
            _request = new GetFangsterRequest { Header = header };
        }

        [TestMethod]
        public void Build_MustReturnFangstListFromFangstListBuilder()
        {
            var result = _builder.Build(_request);
            Assert.AreSame(_fangstList, result.Body.FangstList);
        }
    }
}
