using Draugen.Data;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Helpers;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders;
using Draugen.Services.Builders.Queries;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using Microsoft.Practices.Unity;

namespace Draugen.Services.Configuration
{
    [TestClass]
    public class PerCallContainerTest
    {
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private PerCallContainer _container;
        private Mock<ISession> _session;

        [TestInitialize]
        public void InitializeTest()
        {
            _session = MyMocks.Session();
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Session).Returns(_session.Object);
            _container = new PerCallContainer(_unitOfWorkMock.Object);
        }

        [TestMethod]
        public void Dispose_MustCallDisposeOnUnitOfWork()
        {
            _container.Dispose();
            _unitOfWorkMock.Verify(u => u.Dispose());
        }

        [TestMethod]
        public void Ctor_MustRegisterInstanceOfSession()
        {
            Assert.AreSame(_session.Object, _container.Resolve<ISession>());
        }

        [TestMethod]
        public void Ctor_MustRegisterAllTypes()
        {
            Assert.IsInstanceOfType(_container.Resolve<IRepository<Fangst>>(), typeof(FangstRepository));
            Assert.IsInstanceOfType(_container.Resolve<IAssembler<FangstDto, Fangst>>(), typeof(FangstAssembler));
            Assert.IsInstanceOfType(_container.Resolve<IListBuilder<FangstListDto>>(), typeof(FangstListBuilder));
            Assert.IsInstanceOfType(_container.Resolve<IQueryBuilder<Fangst>>(), typeof(FangstQueryBuilder));
            Assert.IsInstanceOfType(_container.Resolve<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>>(), typeof(GetFangsterResponseBuilder));
        }
    }
}
