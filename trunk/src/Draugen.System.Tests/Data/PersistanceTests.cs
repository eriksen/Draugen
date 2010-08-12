using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.System.Tests.Data
{
    [TestClass]
    public class PersistanceTests : Persistance
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sessionFactory = CreateSessionFactory();
            using(var session = sessionFactory.OpenSession())
            {
                using(var transaction = session.BeginTransaction())
                {

                    var fisker = new Fisker() { EPost = "", Navn = "Simen" };
                    var kommentar = new Kommentar() { Innhold = "En kommentar", Forfatter = fisker};
                    var kommentar2 = new Kommentar() { Innhold = "En kommentar om stedet", Forfatter = fisker };
                    var art = new Art
                                  {
                                      Latin = "Gadus Morhua",
                                      Rekord = 2.0,
                                      Navn = "Tosrk",
                                      Kommentarer = new Collection<Kommentar>() {kommentar}
                                  };
                    var sted = new Sted() {Navn = "Grønøy", Kommentarer = new Collection<Kommentar>() {kommentar2}};

                    session.SaveOrUpdate(fisker);
                    session.SaveOrUpdate(kommentar2);
                    session.SaveOrUpdate(sted);
                    session.SaveOrUpdate(kommentar);
                    session.SaveOrUpdate(art);
                    transaction.Commit();
                }
            }
        }

        [TestMethod]
        public void GenerateDatabase()
        {
            BuildSchema();
        }
    }
}
