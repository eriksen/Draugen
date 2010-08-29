using System.Linq.Expressions;

namespace Draugen.Data.QueryObjects.DynamicLinq
{
    internal class DynamicOrdering
    {
        public Expression Selector;
        public bool Ascending;
    }
}