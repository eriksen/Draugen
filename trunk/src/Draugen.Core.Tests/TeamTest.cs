using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Core
{
    [TestClass]
    public class TeamTest
    {
        private Team _team;

        [TestInitialize]
        public void InitializeTest()
        {
            _team = new Team();
        }

        [TestMethod]
        public void ctor_MustInitializeMedlemList()
        {
            Assert.IsNotNull(_team.Medlemmer);
        }
    }
}
