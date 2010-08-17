using System;
using System.Collections.Generic;
using System.Linq;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Service.Tests
{
    [TestClass]
    public class FangstServiceTests
    {
        private FangstService _service;
        private Mock<IUnitOfWorkFactory> _unitOfWorkFactoryMock;
        private Mock<Repository<Fangst>> _fangstRepositoryMock;
        private Mock<ISession> _sessionMock;
        private Mock<IUnitOfWork> _unitOfWorkMock;

        [TestInitialize]
        public void Initialize()
        {
            _sessionMock = new Mock<ISession>();
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Session).Returns(_sessionMock.Object);
            _fangstRepositoryMock = new Mock<Repository<Fangst>>();
            _unitOfWorkFactoryMock = new Mock<IUnitOfWorkFactory>();
            _unitOfWorkFactoryMock.Setup(u => u.Create()).Returns(_unitOfWorkMock.Object);
            _service = new FangstService(_unitOfWorkFactoryMock.Object, _fangstRepositoryMock.Object);
        }

        [TestMethod]
        public void Dispose_MustCallDisposeOnUnitOfWorkFactory()
        {
            _service.Dispose();
            _unitOfWorkFactoryMock.Verify(u => u.Dispose());
        }

        [TestMethod]
        public void GetFangster_MustSetFangstRepositorySessionFromUnitOfWork()
        {
            _service.GetFangster();
            _fangstRepositoryMock.VerifySet(r => r.Session = _sessionMock.Object);
        }

        [TestMethod]
        public void GetFangster_MustReturnAListOfEnumerableReturnedFromRepository_WhenListContainsZeroElements()
        {
            _fangstRepositoryMock.Setup(f => f.FindAll()).Returns(new List<Fangst>().AsQueryable());
            var result = _service.GetFangster();
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void GetFangster_MustReturnAListOfEnumerableReturnedFromRepository_WhenListContainsMoreElements()
        {
            var list = new List<Fangst> {new Fangst(), new Fangst()};
            _fangstRepositoryMock.Setup(f => f.FindAll()).Returns(list.AsQueryable());
            var result = _service.GetFangster();
            Assert.AreEqual(2, result.Count());
        }
    }
}
