﻿using System.Globalization;
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
        private FangstListBuilder _builder;
        private ServiceHeader _header;
        private FangstDto _fangstDto;

        [TestInitialize]
        public void InitializeTest()
        {
            _header = new ServiceHeader { Culture = "no" };
            _fangstDto = new FangstDto();

            var queryObjects = new QueryContainer<Fangst>();
            var queryBuilder = new Mock<IQueryBuilder<Fangst>>();
            queryBuilder.Setup(q => q.Build()).Returns(queryObjects);

            var fangst = new Fangst();
            var fangster = new[] { fangst };
            var fangstRepository = new Mock<IRepository<Fangst>>();
            fangstRepository.Setup(f => f.FindAll(queryObjects)).Returns(fangster);

            var fangstAssembler = new Mock<IAssembler<FangstDto, Fangst>>();
            fangstAssembler.Setup(a => a.WriteDto(fangst, It.Is<CultureInfo>(c => c.Name == "no"))).Returns(_fangstDto);

            _builder = new FangstListBuilder(queryBuilder.Object, fangstRepository.Object, fangstAssembler.Object);
        }

        [TestMethod]
        public void Build()
        {
            var result = _builder.Build(_header);
            Assert.AreSame(_fangstDto, result[0]);
        }
    }
}
