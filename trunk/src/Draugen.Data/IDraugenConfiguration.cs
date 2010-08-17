using NHibernate;

namespace Draugen.Data
{
    public interface IDraugenConfiguration
    {
        ISessionFactory GetSessionFactory();
    }
}