using System.Collections.Generic;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.ViewData.Home;
using Draugen.Services.ViewData.Shared.Decks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services.DataBuilders.Home
{
    [TestClass]
    public class IndexBuilderTests
    {
        private Mock<IMasterBuilder> _masterBuilder;
        private Mock<IRepository<Fangst>> _fangstRepository;
        private Mock<IAssembler<FangstDeck, IEnumerable<Fangst>>> _fangsterAssembler;
        private IndexBuilder _indexBuilder;

        [TestInitialize]
        public void InitializeTest()
        {
            _masterBuilder = new Mock<IMasterBuilder>();
            _fangstRepository = new Mock<IRepository<Fangst>>();
            _fangsterAssembler = new Mock<IAssembler<FangstDeck, IEnumerable<Fangst>>>();
            _indexBuilder = new IndexBuilder(_masterBuilder.Object, _fangstRepository.Object, _fangsterAssembler.Object);
        }

        [TestMethod]
        public void Create_MustReturnPage()
        {
            _masterBuilder.Setup(m => m.Create<IndexData>()).Returns(new IndexData());
            var queryable = new QueryableFake<Fangst>();
            _fangstRepository.Setup(f => f.FindAll()).Returns(queryable);
            var fangstDeck = new FangstDeck();
            _fangsterAssembler.Setup(f => f.Create(queryable)).Returns(fangstDeck);

            var result = _indexBuilder.Build();
            Assert.AreEqual(fangstDeck, result.Fangster);
        }
    }
}
