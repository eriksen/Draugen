using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Dtos;

namespace Draugen.Services.Builders
{
    public class FangstListBuilder
    {
        private readonly IRepository<Fangst> _repository;
        private readonly IAssembler<FangstDto, Fangst> _assembler;

        public FangstListBuilder(IRepository<Fangst> repository, IAssembler<FangstDto, Fangst> assembler)
        {
            _assembler = assembler;
            _repository = repository;
        }

        public FangstDto[] Build()
        {
            var fangster = _repository.FindAll(CreateQueryObject());
            return fangster.Select(f => _assembler.WriteDto(f)).ToArray();
        }

        private static IQueryObject[] CreateQueryObject()
        {
            return new IQueryObject[]
                       {
                           new Sort("Poeng", SortDirection.Descending),
                           new Page(1, 25)
                       };
        }

    }
}
