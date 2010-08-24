using System;
using System.Linq;
using System.Reflection;
using Draugen.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.Data
{
    /// <summary>
    /// Requires database localhost\CathbaseTest is created
    /// </summary>
    [TestClass]
    public class DraguenConfigurationTests
    {
        private static DraugenConfiguration _configuration;
        private static UnitOfWorkFactory _unitOfWorkFactory;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _configuration = new DraugenConfiguration("Data Source=localhost;Initial Catalog=CatchbaseTest;Integrated Security=True");
            _unitOfWorkFactory = new UnitOfWorkFactory(_configuration.GetSessionFactory());
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            _unitOfWorkFactory.Dispose();
            _unitOfWorkFactory = null;
            _configuration.Dispose();
            _configuration = null;
            _unitOfWorkFactory = null;
        }

        [TestMethod]
        public void Test()
        {
            _configuration.BuildSchema();
            var team = new Team() {Grunnlagt = DateTime.Now, Navn = "Draugen"};
            var fisker = new Fisker() {EPost = "simen.eriksen@draugen.org", Navn = "Simen", Team = team};
            var kommentar = new Kommentar() {Forfatter = fisker, Innhold = "En liten kommentar"};
            var sted = new Sted {Navn = "Grønøy"};
            var art = new Art() {Latin = "Gadhus Morhua", Navn = "Torsk", Rekord = 37.5 };
            var fangst = new Fangst()
                             {
                                 Art = art,
                                 Dato = DateTime.Now,
                                 Fisker = fisker,
                                 Lengde = 108.5,
                                 Sted = sted,
                                 Vekt = 13.75
                             };
            fangst.Kommentarer.Add(kommentar);

            using( _unitOfWorkFactory.Create())
            {
                Persist(team);
                Persist(fisker);
                Persist(sted);
                Persist(art);
                Persist(fangst);
            }
            Test(team);

            _unitOfWorkFactory.Dispose();
            _configuration.Dispose();
        }

        private void Test<T>(T item) where T : Kommenterbar
        {
            T result;
            using(_unitOfWorkFactory.Create())
            {
                result = Load<T>(item.Id);
            }
            foreach(var property in typeof(T).GetProperties(BindingFlags.Public))
            {
                var resultValue = property.GetValue(result, null);
                var originalValue = property.GetValue(item, null);
                Assert.AreEqual(originalValue, resultValue, "PersistanceError" + typeof(T).Name + ":" + property.Name);
            }
        }

        private T Load<T>(int id) where T : Kommenterbar
        {
            var repository = new Repository<T>(_unitOfWorkFactory);
            return repository.FindAll().Single(x => x.Id == id);
        }

        private void Persist<T>(T item) where T : Kommenterbar
        {

            var repository = new Repository<T>(_unitOfWorkFactory);
                repository.Add(item);
            
        }

    }
}
