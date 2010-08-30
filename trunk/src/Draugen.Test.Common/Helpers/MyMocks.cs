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
            var mock = new Mock<ISession>();
            mock.Setup(s => s.IsOpen).Returns(true);
            return mock;
        }

        public static Mock<ISession> Session(Mock<ITransaction> transaction)
        {
            var mock = Session();
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
    }
}
