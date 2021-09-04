using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class ParentsElefe
    {
        public string Code { get; set; }
        public string CodeEleve { get; set; }
        public string CodeParent { get; set; }
        public string CodeEcole { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Elefe CodeEleveNavigation { get; set; }
        public virtual Parent CodeParentNavigation { get; set; }
    }
}
