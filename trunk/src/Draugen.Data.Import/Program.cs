﻿using System.IO;

namespace Draugen.Data.Import
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration =
                new DraugenConfiguration("Data Source=localhost;Initial Catalog=Catchbase;Integrated Security=True");
            configuration.BuildSchema();
            var composer = new Composer(@"C:\Projects\Draugen\trunk\src\Draugen.Data.Import\draugen_org_data");
            using (var unitOfWork = new UnitOfWork(configuration.GetSessionFactory()))
            {
                composer.Save(unitOfWork.Session);
            }
        }
    }
}
