using System.Linq;
using Moq;
using NHibernate;

namespace Draugen.Helpers
{
    public static class MyMocks
    {
        public static Mock<ITransaction> Transaction()
        {
            var mock = new Mock<ITransaction>();
            mock.Setup(t => t.IsActive).Returns(true);
            return mock;
        }

        public static Mock<ISession> Session()
        {
            return Session(Transaction());
        }

        public static Mock<ISession> Session(Mock<ITransaction> transaction)
        {
            var mock = new Mock<ISession>();
            mock.Setup(m => m.Transaction).Returns(transaction.Object);
            return mock;
        }

        public static Mock<ISessionFactory> SessionFactory()
        {
            return SessionFactory(Session());
        }

        public static Mock<ISessionFactory> SessionFactory(Mock<ISession> session)
        {
            var mock = new Mock<ISessionFactory>();
            mock.Setup(m => m.OpenSession()).Returns(session.Object);
            return mock;
        }

        public static Mock<IQueryable<T>> Queryable<T>() 
        {
            return new Mock<IQueryable<T>>();
        }
    }
}
