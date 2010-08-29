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
            new TestablePropertyQueryObject("Navn").TestValidate<Art>();
            new TestablePropertyQueryObject("Art.Id").TestValidate<Fangst>();
            new TestablePropertyQueryObject("Fisker.Navn").TestValidate<Fangst>();
        }

        [TestMethod]
        public void Refine_MustThrowArgumentException_WhenPropertyDoesNotExist()
        {
            const string expectedMessage = "Property Bogus in relation to Art does not exist";
            try
            {
                new TestablePropertyQueryObject("Bogus").TestValidate<Art>();
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
            const string expectedMessage = "Property Bogus in relation to Fangst does not exist";
            try
            {
                new TestablePropertyQueryObject("Art.Bogus").TestValidate<Fangst>();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(expectedMessage, e.Message);
                return;
            }
            Assert.Fail();
        }

        private class TestablePropertyQueryObject : PropertyQueryObject
        {
            public TestablePropertyQueryObject(string propertyName) : base(propertyName) {}

            public void TestValidate<T>()
            {
                ValidateProperties<T>();
            }
        }
    }


}
