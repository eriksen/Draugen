using Draugen.Services.ViewData.Shared.Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Draugen.Services.Assemblers.Decks
{
    [TestClass]
    public class FangsterAssemblerTests
    {
        private FangsterAssembler _assembler;
        private Mock<IAssembler<FangstCard, Fangst>> _fangstAssemblerMock;

        [TestInitialize]
        public void InitializeTest()
        {
            _fangstAssemblerMock = new Mock<IAssembler<FangstCard, Fangst>>();
            _assembler = new FangsterAssembler(_fangstAssemblerMock.Object);
        }

        [TestMethod]
        public void Create_MustCreateFangstDeck()
        {
            var fangst1 = new Fangst();
            var fangst2 = new Fangst();
            var fangstCard1 = new FangstCard();
            var fangstCard2 = new FangstCard();
            var fangster = new[] { fangst1, fangst2 };
            _fangstAssemblerMock.Setup(f => f.Create(fangst1)).Returns(fangstCard1);
            _fangstAssemblerMock.Setup(f => f.Create(fangst2)).Returns(fangstCard2);
            var result = _assembler.Create(fangster);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains(fangstCard1));
            Assert.IsTrue(result.Contains(fangstCard2));
        }
    }
}
