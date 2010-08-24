using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{
    public class FangstBuilder : BuilderBase<Fangst>
    {
        private readonly Regex _expression = new Regex(@"INSERT INTO fangst VALUES \((?<id>\d{1,3}), (?<fiskerid>\d{1,3}), (?<artid>\d{1,3}), (?<stedid>\d{1,3}), (?<dato>'[^']*'), (?<vekt>\d{1,5}), (?<lengde>\d{1,5}), (?<metode>'[^']*'), (?<comment>'[^']*')");
        private readonly Dictionary<int, Sted> _steder;
        private readonly Dictionary<int, Fisker> _fiskere;
        private readonly Dictionary<int, Art> _arter;

        public FangstBuilder(Dictionary<int, Sted> steder, Dictionary<int, Fisker> fiskere, Dictionary<int, Art> arter)
        {
            _arter = arter;
            _fiskere = fiskere;
            _steder = steder;
        }

        protected override Regex Expression
        {
            get { return _expression; }
        }

        protected override Fangst GetEntity(Match match)
        {
            var id = match.Groups["id"].AsInt();
            var fangst = new Fangst()
                             {
                                 Art = _arter[match.Groups["artid"].AsInt()],
                                 Dato = match.Groups["dato"].AsDate(),
                                 Fisker = _fiskere[match.Groups["fiskerid"].AsInt()],
                                 Lengde = match.Groups["lengde"].AsCentimeters(),
                                 Sted = _steder[match.Groups["stedid"].AsInt()],
                                 Vekt = match.Groups["vekt"].AsKilo(),
                                 LegacyId = match.Groups["id"].AsInt()
                             };
            fangst.Kommentarer.Add(new Kommentar() { Forfatter = fangst.Fisker, Innhold = match.Groups["comment"].AsString()});
            return fangst;
        }

    }
}
