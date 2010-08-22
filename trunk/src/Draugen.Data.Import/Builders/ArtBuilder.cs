using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{
    public class ArtBuilder : BuilderBase<Art>
    {
        private readonly Regex _expression = new Regex(@"INSERT INTO art VALUES \((?<id>\d{1,3}), (?<name>'[^']*'), (?<record>\d*), (?<comment>'[^']*')");
        private readonly Fisker _forfatter;

        public ArtBuilder(Fisker forfatter)
        {
            _forfatter = forfatter;
        }

        protected override Regex Expression
        {
            get { return _expression; }
        }

        protected override Art GetEntity(Match match)
        {
            var art = new Art
                          {
                              Latin = "",
                              Navn = match.Groups["name"].AsString(),
                              Rekord = match.Groups["record"].AsKilo()
                          };
            art.Kommentarer.Add(new Kommentar() { Forfatter = _forfatter, Innhold = match.Groups["comment"].AsString()});
            return art;
        }
    }
}
