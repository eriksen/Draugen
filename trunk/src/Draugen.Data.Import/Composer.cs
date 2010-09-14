using System.Collections.Generic;
using System.IO;
using System.Text;
using Draugen.Data.Import.Builders;
using Draugen.Data.Paging;
using Draugen.Data.Repositories;
using NHibernate;

namespace Draugen.Data.Import
{
    public class Composer
    {
        private readonly Dictionary<int, Team> _teams;
        private readonly Dictionary<int, Fisker> _fiskere;
        private readonly Dictionary<int, Art> _arter;
        private readonly Dictionary<int, Sted> _steder;
        private readonly Dictionary<int, Fangst> _fangster;


        public Composer(string oldDbDumpFile)
        {
            var content = File.ReadAllText(oldDbDumpFile, Encoding.UTF8);
            _teams = new TeamBuilder().Build(content);
            _fiskere = new FiskerBuilder(_teams[0]).Build(content);
            _arter = new ArtBuilder(_fiskere[25]).Build(content);
            _steder = new StedBuilder(_fiskere[2]).Build(content);
            _fangster = new FangstBuilder(_steder, _fiskere, _arter).Build(content);
        }

        public void Save(ISession unitOfWorkFactory)
        {
            SaveEntities(_teams, unitOfWorkFactory);
            SaveEntities(_fiskere, unitOfWorkFactory);
            SaveEntities(_arter, unitOfWorkFactory);
            SaveEntities(_steder, unitOfWorkFactory);
            SaveEntities(_fangster, unitOfWorkFactory);
        }

        private static void SaveEntities<T>(IDictionary<int, T> entities, ISession unitOfWorkFactory) where T : Kommenterbar
        {
            var repository = new Repository<T>(unitOfWorkFactory, new PageBuilder<T>());
            foreach(var entity in entities)
            {
                repository.Add(entity.Value);
            }
        }
    }
}
