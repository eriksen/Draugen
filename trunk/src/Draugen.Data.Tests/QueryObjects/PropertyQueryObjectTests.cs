using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data.QueryObjects
{
    [TestClass]
    public class PropertyQueryObjectTests
    {
        [TestMethod]
        public void Validate_MustNotThrow_WhenNoErrorExists()
        {
            new TestablePropertyQueryObject<Art>("Navn").TestValidate();
            new TestablePropertyQueryObject<Fangst>("Art.Id").TestValidate();
            new TestablePropertyQueryObject<Fangst>("Fisker.Navn").TestValidate();
        }

        [TestMethod]
        public void Refine_MustThrowArgumentException_WhenPropertyDoesNotExist()
        {
            const string expectedMessage = "Property Bogus in relation to Art does not exist";
            try
            {
                new TestablePropertyQueryObject<Art>("Bogus").TestValidate();
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
                new TestablePropertyQueryObject<Fangst>("Art.Bogus").TestValidate();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(expectedMessage, e.Message);
                return;
            }
            Assert.Fail();
        }

        private class TestablePropertyQueryObject<T> : PropertyQueryObject<T> where T : DomainObject
        {
            public TestablePropertyQueryObject(string propertyName) : base(propertyName) {}

            public void TestValidate()
            {
                ValidateProperties();
            }
        }
    }


}
