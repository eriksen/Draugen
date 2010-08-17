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
        private const string ConnectionString = "Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True";

        [TestMethod]
        public void Add_MustAddItem()
        {
            var unitOfWorkFactory = new UnitOfWorkFactory(new DraugenConfiguration(ConnectionString).GetSessionFactory());
            var g1 = Guid.NewGuid().ToString();
            var g2 = Guid.NewGuid().ToString();

            using(var manager = unitOfWorkFactory.Create())
            {
                var repository = new Repository<Art>{ Session = manager.Session };
                repository.Add(new Art() { Latin = g1, Navn = "Torsk", Rekord = 37.5 });
                var art = new Art() {Latin = g2, Navn = "Beltedyr", Rekord = 17.5};
                repository.Add(art);

                var stedRepository = new Repository<Sted> { Session = manager.Session };
                var sted = new Sted() {Navn = "Moloen"};
                stedRepository.Add(sted);

                var fiskerRepository = new Repository<Fisker> { Session = manager.Session };
                var fisker = new Fisker() {EPost = "simen", Navn = "Simen"};
                fiskerRepository.Add(fisker);

                var fangstRepository = new Repository<Fangst> { Session = manager.Session };
                var fangst = new Fangst() {Art = art, Fisker = fisker, Lengde = 2.0, Sted = sted, Vekt = 56};
                fangstRepository.Add(fangst);

            }

            using (var manager = unitOfWorkFactory.Create())
            {
                var repository = new Repository<Art> { Session = manager.Session };
                var arter = repository.FindAll();
                Assert.IsNotNull(arter.Where(a => a.Latin == g1).FirstOrDefault());
                Assert.IsNotNull(arter.Where(a => a.Latin == g1).FirstOrDefault());
            }

            using (var manager = unitOfWorkFactory.Create())
            {
                var repository = new Repository<Art> { Session = manager.Session };
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
