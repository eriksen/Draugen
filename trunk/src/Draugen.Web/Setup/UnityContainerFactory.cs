using System.IO;
using Draugen.Data;
using Microsoft.Practices.Unity;

namespace Draugen.Setup
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
            return File.ReadAllText(@"c:\projects\Draugen\ConnectionString.txt");
            //return "Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True";
        }
    }
}