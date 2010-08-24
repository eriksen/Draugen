using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{
    public class StedBuilder : BuilderBase<Sted>
    {
        private readonly Regex _expression = new Regex(@"INSERT INTO sted VALUES \((?<id>\d{1,3}), (?<name>'[^']*'), (?<comment>'[^']*'), (?<comment2>[^)]*)\)");
        private readonly Fisker _forfatter;

        public StedBuilder(Fisker forfatter)
        {
            _forfatter = forfatter;
        }

        protected override Regex Expression
        {
            get { return _expression; }
        }

        protected override Sted GetEntity(Match match)
        {
            var sted =  new Sted()
                       {
                           Navn = match.Groups["name"].AsString(),
                           LegacyId = match.Groups["id"].AsInt()
                       };
            sted.Kommentarer.Add(new Kommentar() { Forfatter = _forfatter, Innhold = match.Groups["comment"].AsString() });
            return sted;
        }
    }
}
