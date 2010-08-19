using System;
using System.Collections.Generic;
using System.Linq;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Draugen.Services.Assemblers;
using Draugen.Services.PageBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Draugen.Service.Tests
{
    [TestClass]
    public class FangstServiceTests
    {
        private PageDataService _service;
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
            
            _service = new PageDataService(_unitOfWorkFactoryMock.Object, _fangstRepositoryMock.Object, new HomeBuilder(new FangstAssembler(new KommentarAssembler())));
        }
    }
}
