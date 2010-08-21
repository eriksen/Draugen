using Draugen.Data;
using Microsoft.Practices.Unity;

namespace Draugen.Setup
{
    public class UnityContainerFactory
    {
        public static IUnityContainer Create()
        {
            var configuration = new DraugenConfiguration("Data Source=KANE;Initial Catalog=CatchbaseTest;Integrated Security=True");
            var sessionFactory = configuration.GetSessionFactory();
            return new DraugenUnityContainer(sessionFactory);
        }

    }
}