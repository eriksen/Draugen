using NHibernate;

namespace Draugen.Data
{
    public interface ISessionProvider
    {
        ISession Session { get; }
    }
}