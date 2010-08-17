using System.Collections.Generic;

namespace Draugen.Web.Models
{
    public class Fangster
    {
        public IEnumerable<Fangst> List { get; set; }
    }

    public class Fangst
    {
        public string Vekt { get; set; }
    }
}