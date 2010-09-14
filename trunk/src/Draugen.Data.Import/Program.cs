using System.IO;
using System.Reflection;
using FluentNHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Draugen.Data.Import
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration =
                new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True");
            BuildDatabase(configuration);
            var composer = new Composer(@"C:\Projects\Draugen\trunk\src\Draugen.Data.Import\draugen_org_data");
            using (var unitOfWork = new UnitOfWork(configuration.GetSessionFactory()))
            {
                unitOfWork.BeginTransaction();
                composer.Save(unitOfWork.Session);
                unitOfWork.CommitTransaction();
            }
        }

        static void BuildDatabase(DraugenConfiguration configuration)
        {
            var propertyInfo = configuration.GetType().GetField("_configuration", BindingFlags.NonPublic | BindingFlags.Static);
            var fluentConfiguration = (FluentConfiguration)propertyInfo.GetValue(configuration);
            var config = fluentConfiguration.BuildConfiguration();
            new SchemaExport(config).Create(false, true);
        }
    }
}
