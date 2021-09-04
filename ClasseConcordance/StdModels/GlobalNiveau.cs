using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalNiveau
    {
        public GlobalNiveau()
        {
            GlobalSections = new HashSet<GlobalSection>();
        }

        public int CodeNiveau { get; set; }
        public string IntituleNiveau { get; set; }

        public virtual ICollection<GlobalSection> GlobalSections { get; set; }
    }
}
