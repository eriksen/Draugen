using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{

    public class FiskerBuilder : BuilderBase<Fisker>
    {
        private readonly Regex _expression = new Regex(
            @"INSERT INTO fisker VALUES \((?<id>\d{1,3}), (?<name>'[^']*'), '[^']*', '[^']*', '[^']*', (?<status>\d), (?<email>'[^']*')");

        private readonly Team _team;

        public FiskerBuilder(Team team)
        {
            _team = team;
        }

        protected override Regex Expression
        {
            get { return _expression; }
        }

        protected override Fisker GetEntity(Match match)
        {
            return new Fisker()
                       {
                           EPost = match.Groups["email"].AsString(),
                           Navn = match.Groups["name"].AsString(),
                           Tittel = match.Groups["status"].AsStatus(),
                           Team = _team
                       };
        }
    }
}
