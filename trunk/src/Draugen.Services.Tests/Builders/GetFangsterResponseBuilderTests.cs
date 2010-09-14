using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services.Builders
{
    [TestClass]
    public class GetFangsterResponseBuilderTests
    {
        private Mock<IListBuilder<FangstListDto>> _fangstBuilder;
        private GetFangsterResponseBuilder _builder;
        private FangstListDto _fangstList;
        private GetFangsterRequest _request;

        [TestInitialize]
        public void InitializeTest()
        {
            _fangstBuilder = new Mock<IListBuilder<FangstListDto>>();
            
            _builder = new GetFangsterResponseBuilder(_fangstBuilder.Object);
            _fangstList = new FangstListDto(new FangstDto[]{});
            _request = new GetFangsterRequest { Header = new ServiceHeader() };
            //_fangstBuilder.Setup(f => f.Build(_request.Header)).Returns(_fangstList);
        }

        [TestMethod]
        public void Build_MustReturnFangstListFromFangstListBuilder()
        {
            var result = _builder.Build(_request);
            Assert.AreSame(_fangstList, result.Body.FangstList);
        }
    }
}
