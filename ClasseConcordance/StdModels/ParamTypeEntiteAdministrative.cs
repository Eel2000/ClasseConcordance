using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeEntiteAdministrative
    {
        public ParamTypeEntiteAdministrative()
        {
            ParamEntiteAdministratives = new HashSet<ParamEntiteAdministrative>();
        }

        public string CodeTypeEntiteAdministrative { get; set; }
        public string LibelleTypeEntite { get; set; }
        public string DenominationAutorite { get; set; }
        public int? NiveauEntite { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<ParamEntiteAdministrative> ParamEntiteAdministratives { get; set; }
    }
}
