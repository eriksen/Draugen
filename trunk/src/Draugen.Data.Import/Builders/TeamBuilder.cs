using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{
    public class TeamBuilder : BuilderBase<Team>
    {
        public override Dictionary<int, Team> Build(string content)
        {
            return new Dictionary<int, Team>
                                 {{0, new Team() {Grunnlagt = Convert.ToDateTime("2001-04-01"), Navn = "Draugen"}}};
        }

        protected override Regex Expression
        {
            get { throw new NotImplementedException(); }
        }

        protected override Team GetEntity(Match match)
        {
            throw new NotImplementedException();
        }
    }
}
