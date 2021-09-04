using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamPay
    {
        public ParamPay()
        {
            GlobalEcoles = new HashSet<GlobalEcole>();
        }

        public string CodePays { get; set; }
        public string CodeEntiteAdministrative { get; set; }
        public string ProfilPays { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamEntiteAdministrative CodeEntiteAdministrativeNavigation { get; set; }
        public virtual ICollection<GlobalEcole> GlobalEcoles { get; set; }
    }
}
