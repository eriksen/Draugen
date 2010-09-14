using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.QueryObjects
{
    [TestClass]
    public class PropertyQueryObjectTests
    {
        [TestMethod]
        public void Validate_MustNotThrow_WhenNoErrorExists()
        {
            new TestablePropertyQuery<Art>("Navn").TestValidate();
            new TestablePropertyQuery<Fangst>("Art.Id").TestValidate();
            new TestablePropertyQuery<Fangst>("Fisker.Navn").TestValidate();
        }

        [TestMethod]
        public void Refine_MustThrowArgumentException_WhenPropertyDoesNotExist()
        {
            const string expectedMessage = "Property Bogus in relation to Art does not exist";
            try
            {
                new TestablePropertyQuery<Art>("Bogus").TestValidate();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(expectedMessage, e.Message);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void Refine_MustThrowArguementException_WhenSubPropertyDoesNotExist()
        {
            const string expectedMessage = "Property Bogus in relation to Art does not exist";
            try
            {
                new TestablePropertyQuery<Fangst>("Art.Bogus").TestValidate();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(expectedMessage, e.Message);
                return;
            }
            Assert.Fail();
        }

        private class TestablePropertyQuery<T> : PropertyQuery<T> where T : DomainObject
        {
            public TestablePropertyQuery(string propertyName) : base(propertyName) {}

            public void TestValidate()
            {
                ValidateProperties();
            }
        }
    }


}
