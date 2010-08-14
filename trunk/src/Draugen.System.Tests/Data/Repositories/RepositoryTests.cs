using System;
using System.Linq;
using Draugen.Data;
using Draugen.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Draugen.System.Tests.Data.Repositories
{
    [TestClass]
    public class RepositoryTests
    {
        private const string ConnectionString = "Data Source=KANE;Initial Catalog=CatchbaseTest;Integrated Security=True";

        [TestMethod]
        public void Add_MustAddItem()
        {
            var g1 = Guid.NewGuid().ToString();
            var g2 = Guid.NewGuid().ToString();

            using(var manager = new SessionManager())
            {
                var repository = new Repository<Art>(manager.Session);
                repository.Add(new Art() { Latin = g1, Navn = "Torsk", Rekord = 37.5 });
                repository.Add(new Art() { Latin = g2, Navn = "Beltedyr", Rekord = 17.5 });
            }

            using(var manager = new SessionManager())
            {
                var repository = new Repository<Art>(manager.Session);
                var arter = repository.FindAll();
                Assert.IsNotNull(arter.Where(a => a.Latin == g1).FirstOrDefault());
                Assert.IsNotNull(arter.Where(a => a.Latin == g1).FirstOrDefault());
            }

            using(var manager = new SessionManager())
            {
                var repository = new Repository<Art>(manager.Session);
                var preCount = repository.FindAll().Count();
                foreach(var art in repository.FindAll().Where(a => a.Latin == g1 || a.Latin == g2))
                {
                    repository.Delete(art);
                }
                var postCount = repository.FindAll().Count();
                Assert.AreEqual(preCount - 2, postCount);
            }
        }
    }
}
