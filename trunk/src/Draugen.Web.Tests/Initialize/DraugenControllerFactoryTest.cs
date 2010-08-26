using System;
using System.Web.Mvc;
using System.Web.Routing;
using Draugen.Configuration;
using Draugen.Initialize;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Web.Setup
{
    [TestClass]
    public class DraugenControllerFactoryTest
    {
        private UnityContainer _container;
        private TestableControllerFactory _factory;

        [TestInitialize]
        public void Initialize()
        {
            _container = new UnityContainer();
            _factory = new TestableControllerFactory(_container);
        }

        [TestMethod]
        public void GetControllerinstance_MustReturnNull_WhenControllerTypeIsNull()
        {
            var controllerType = (Type) null;
            var result = _factory.TestGetControllerInstance(new RequestContext(), controllerType);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetControllerinstance_MustReturnControllerReturnedFromContainer()
        {

            var result = _factory.TestGetControllerInstance(new RequestContext(), typeof(TestableController));
            Assert.IsInstanceOfType(result, typeof(TestableController));
        }
    }

    public class TestableController : Controller{}

    public class TestableControllerFactory : DraugenControllerFactory
    {
        public TestableControllerFactory (IUnityContainer container) : base(container){}

        public IController TestGetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}
