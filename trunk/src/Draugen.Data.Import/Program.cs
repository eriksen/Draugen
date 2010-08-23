using System.IO;

namespace Draugen.Data.Import
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration =
                new DraugenConfiguration(File.ReadAllText(@"c:\projects\Draugen\ConnectionString.txt"));
            configuration.BuildSchema();
            var unitOfWorkFactory = new UnitOfWorkFactory(configuration.GetSessionFactory());
            
            var composer = new Composer(@"C:\Projects\Draugen\trunk\src\Draugen.Data.Import\draugen_org_data");

            using(unitOfWorkFactory.Create())
            {
                composer.Save(unitOfWorkFactory);
            }
        }
    }
}
