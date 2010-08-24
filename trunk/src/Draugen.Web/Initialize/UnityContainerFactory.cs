using Draugen.Data;
using Microsoft.Practices.Unity;

namespace Draugen.Initialize
{
    public class UnityContainerFactory
    {
        public static IUnityContainer Create()
        {
            var configuration = new DraugenConfiguration(ReadConnectionString());
            var sessionFactory = configuration.GetSessionFactory();
            return new DraugenUnityContainer(sessionFactory);
        }

        private static string ReadConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True";
        }
    }
}