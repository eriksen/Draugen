using System.Web.Mvc;
using Draugen.Configuration;
using Draugen.Initialize;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using Microsoft.Practices.Unity;

namespace Draugen
{
    [TestClass]
    public class MvcApplicationTests
    {
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            TestableMvcApplication.Configure();
        }

        [TestMethod]
        public void ConfigureDraugen_MustSetupDraugenUnityContainer()
        {
            Assert.IsInstanceOfType(TestableMvcApplication.Container, typeof(DraugenContainer));
            Assert.IsNotNull(TestableMvcApplication.Container.Resolve<ISessionFactory>());
        }

        [TestMethod]
        public void ConfigureDraugen_MustRegisterViewEngines()
        {
            Assert.AreEqual(1, ViewEngines.Engines.Count);
            Assert.IsInstanceOfType(ViewEngines.Engines[0], typeof(DraugenWebFormViewEngine));
        }

        [TestMethod]
        public void ConfigureDraugen_MustSetControllerFactory()
        {
            Assert.IsInstanceOfType(ControllerBuilder.Current.GetControllerFactory(), typeof (DraugenControllerFactory));
        }

        private class TestableMvcApplication : MvcApplication
        {
            public static void Configure(){ ConfigureDraugen();}
            public new static IUnityContainer Container { get { return MvcApplication.Container; } }
        }
    }
}