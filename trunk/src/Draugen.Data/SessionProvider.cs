using NHibernate;

namespace Draugen.Data
{
    public class SessionProvider : ISessionProvider
    {
        public ISession Session
        {
            get { return SessionFactory.Session; }
        }
    }
}