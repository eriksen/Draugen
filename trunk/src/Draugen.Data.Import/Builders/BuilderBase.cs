using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Draugen.Data.Import.Builders
{
    public abstract class BuilderBase<T>
    {
        protected abstract Regex Expression { get;}
        protected abstract T GetEntity(Match match);

        public virtual Dictionary<int, T> Build(string content)
        {
            var entities = new Dictionary<int, T>();
            var match = Expression.Match(content);
            while (match.Success)
            {
                var entity = GetEntity(match);
                entities.Add(match.Groups["id"].AsInt(), entity);
                match = match.NextMatch();
            }
            return entities;
        }
    }
}
